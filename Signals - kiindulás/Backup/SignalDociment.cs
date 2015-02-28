using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Signals
{
	public class SignalDociment : Document
	{
		List<SignalValue> signalValues = new List<SignalValue>();
		
		public SignalDociment(string name) : base(name)
		{
			// Insert code required on object creation below this point.
			signalValues.Add(new SignalValue(5));
			
		}
	}
}