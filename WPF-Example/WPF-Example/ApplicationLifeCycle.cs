using bytePassion.Library.Essentials.WpfTools.Application;
using System.Windows;

namespace WPF_Example
{
    internal class ApplicationLifeCycle : IApplicationLifeCycle
    {
        public void Startup(StartupEventArgs startupEventArgs)
        {
            var mainWindow = new MainWindow();

            mainWindow.Show();
        }

        public void SessionEnding(SessionEndingCancelEventArgs sessionEndingCancelEventArgs)
        {
            // Here I could prevent for the app to close
        }

        public void Exit(ExitEventArgs exitEventArgs)
        {
            // Here I could cleanup resources
        }
    }
}
