using System.ComponentModel;
using WPF_Example.ViewModels.CommandExample;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        public MainWindowViewModelSampleData()
        {
            CommandExampleViewModel = new CommandExampleViewModelSampleData();

            Title = "Design-Time-Title";
        }

        public ICommandExampleViewModel CommandExampleViewModel { get; }

        public string Title { get; }

        public void                              Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}