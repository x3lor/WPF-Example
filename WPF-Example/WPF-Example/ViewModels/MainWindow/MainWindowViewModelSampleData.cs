using System.ComponentModel;
using WPF_Example.ViewModels.CommandExample;
using WPF_Example.ViewModels.ConverterAndBehaviorExample;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        public MainWindowViewModelSampleData()
        {
            CommandExampleViewModel = new CommandExampleViewModelSampleData();
            ConverterAndBehaviorExampleViewModel = new ConverterAndBehaviorExampleViewModelSampleData();

            Title = "Design-Time-Title";
        }

        public ICommandExampleViewModel CommandExampleViewModel { get; }
        public IConverterAndBehaviorExampleViewModel ConverterAndBehaviorExampleViewModel { get; }

        public string Title { get; }

        public void Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}