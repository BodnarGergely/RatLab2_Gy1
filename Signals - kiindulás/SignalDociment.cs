using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;


namespace Signals
{
	public class SignalDociment : Document
	{
		public List<SignalValue> signalValues = new List<SignalValue>();

		
		public SignalDociment(string name) : base(name)
		{
			// Insert code required on object creation below this point.
			signalValues.Add(new SignalValue(5, DateTime.Now));
            signalValues.Add(new SignalValue(32, DateTime.Now));
			
		}

        public override void SaveDocument(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach(SignalValue sv in signalValues)
                {
                    string dt = sv.TimeStamp.ToUniversalTime().ToString("o") + ('\t') + sv.Value.ToString();
                    Console.WriteLine(dt);
                }
            }
        }

        public override void LoadDocument(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                // Read and display lines from the file until the end of  
                // the file is reached. 
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] columns = line.Split('\t');

                    signalValues.Add(new SignalValue(( double.Parse(columns[0] )), ( DateTime.Parse(columns[1]).ToLocalTime() )));
                }
            }
            TraceValues();

        }

        void TraceValues()
        {
            foreach (SignalValue value in signalValues)
                System.Diagnostics.Trace.WriteLine(value.ToString());
        }
	}
}

