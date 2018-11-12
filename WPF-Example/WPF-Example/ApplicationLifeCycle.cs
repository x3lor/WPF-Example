﻿using bytePassion.Library.Essentials.WpfTools.Application;
using System.Windows;
using WPF_Example.ViewModels.MainWindow;

namespace WPF_Example
{
    internal class ApplicationLifeCycle : IApplicationLifeCycle
    {
        public void Startup(StartupEventArgs startupEventArgs)
        {
            var mainWindowViewModel = new MainWindowViewModel("Run-Time-Title");

            var mainWindow = new MainWindow
                             {
                                 DataContext = mainWindowViewModel
                             };

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
