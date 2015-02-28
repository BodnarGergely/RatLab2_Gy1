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
	public class SignalValue
	{
		double signalValue;
		DateTime timeStamp; 
		
		public double Value
		{
			get
			{
				return value;
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
		
		public SignalValue(double Value, )
		{
			signalValue = signalValue;
			timeStamp = DateTime.Now;
			// Insert code required on object creation below this point.
		}
	}
}