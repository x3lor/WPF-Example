﻿using System;
using System.Windows.Threading;

namespace bytePassion.Library.Essentials.WpfTools.FrameworkExtensions
{
	public static class DispatcherExtension
	{
		public static void DelayInvoke(this Dispatcher dispatcher, Action action, TimeSpan delay)
		{
			var timer = new DispatcherTimer()
			            {
				            Interval = delay
			            };

			timer.Tick += (sender, args) =>
			              {
				              dispatcher.Invoke(action);
				              timer.Stop();
			              };

			timer.Start();
		}
	}
}
