using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Signals
{
	public class SignalValue
	{
		double signalValue;
		DateTime timeStamp; 
		
		public double Value
		{
			get
			{
                return signalValue;
			}
			set
			{
				signalValue = value;
			}
		}
		
		public DateTime TimeStamp
		{
			get
			{
				return timeStamp;
			}
			set
			{
				timeStamp = value;
			}
		}
		
		public SignalValue(double Svalue, DateTime date)
		{
            signalValue = Svalue;
            timeStamp = date;
			// Insert code required on object creation below this point.
		}
	}
}