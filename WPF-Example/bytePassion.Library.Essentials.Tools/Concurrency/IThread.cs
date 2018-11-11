﻿namespace bytePassion.Library.Essentials.Tools.Concurrency
{
	public interface IThread
	{
		void Run();
		void Stop();
		
		bool IsRunning { get; }
	}
}