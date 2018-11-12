using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.ComponentModel;
using WPF_Example.ViewModels.CommandExample;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModel : ViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(string title, 
                                   ICommandExampleViewModel commandExampleViewModel)
        {
            Title = title;
            CommandExampleViewModel = commandExampleViewModel;
        }

        public ICommandExampleViewModel CommandExampleViewModel { get; }

        public string Title { get; }
        
        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
