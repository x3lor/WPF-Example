﻿using bytePassion.Library.Essentials.WpfTools.Application;
using System.Windows;
using WPF_Example.DataService;
using WPF_Example.ViewModels.CommandExample;
using WPF_Example.ViewModels.ConverterAndBehaviorExample;
using WPF_Example.ViewModels.ListExample;
using WPF_Example.ViewModels.MainWindow;

namespace WPF_Example
{
    internal class ApplicationLifeCycle : IApplicationLifeCycle
    {
        public void Startup(StartupEventArgs startupEventArgs)
        {
            var dataProvider = new ExampleDataProvider();
                 
            var listExampleViewModel = new ListExampleViewModel(dataProvider);
            var converterAndBehaviorExampleViewModel = new ConverterAndBehaviorExampleViewModel();
            var commandExampleViewModel = new CommandExampleViewModel();
            var mainWindowViewModel = new MainWindowViewModel("Run-Time-Title",
                                                              commandExampleViewModel,
                                                              converterAndBehaviorExampleViewModel,
                                                              listExampleViewModel);

            var mainWindow = new MainWindow
                             {
                                 DataContext = mainWindowViewModel
                             };

            mainWindow.Show();
        }

        public void SessionEnding(SessionEndingCancelEventArgs sessionEndingCancelEventArgs)
        {
            // Here I could prevent for the app from closing
        }

        public void Exit(ExitEventArgs exitEventArgs)
        {
            // Here I could cleanup resources
        }
    }
}
