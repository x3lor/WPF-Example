using System.ComponentModel;
using WPF_Example.ViewModels.CommandExample;
using WPF_Example.ViewModels.ConverterAndBehaviorExample;
using WPF_Example.ViewModels.ListExample;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        public MainWindowViewModelSampleData()
        {
            CommandExampleViewModel = new CommandExampleViewModelSampleData();
            ConverterAndBehaviorExampleViewModel = new ConverterAndBehaviorExampleViewModelSampleData();
            ListExampleViewModel = new ListExampleViewModelSampleData();

            Title = "Design-Time-Title";
        }

        public ICommandExampleViewModel CommandExampleViewModel { get; }
        public IConverterAndBehaviorExampleViewModel ConverterAndBehaviorExampleViewModel { get; }
        public IListExampleViewModel ListExampleViewModel { get; }

        public string Title { get; }

        public void Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}