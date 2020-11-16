using System;
using System.Windows;
using System.Windows.Threading;

namespace Samples.Misc
{
	public partial class Sample : Window
	{
		public Sample()
		{
			
			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromMilliseconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
		}
		void timer_Tick(object sender, EventArgs e)
		{
			lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
		}
	}
}