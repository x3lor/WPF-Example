using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.ComponentModel;
using WPF_Example.ViewModels.CommandExample;
using WPF_Example.ViewModels.ConverterAndBehaviorExample;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModel : ViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(string title, 
                                   ICommandExampleViewModel commandExampleViewModel, 
                                   IConverterAndBehaviorExampleViewModel converterAndBehaviorExampleViewModel)
        {
            Title = title;
            CommandExampleViewModel = commandExampleViewModel;
            ConverterAndBehaviorExampleViewModel = converterAndBehaviorExampleViewModel;
        }

        public ICommandExampleViewModel CommandExampleViewModel { get; }
        public IConverterAndBehaviorExampleViewModel ConverterAndBehaviorExampleViewModel { get; }

        public string Title { get; }
        
        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
