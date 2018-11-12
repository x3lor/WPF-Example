using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using WPF_Example.ViewModels.CommandExample;

namespace WPF_Example.ViewModels.MainWindow
{
    internal interface IMainWindowViewModel : IViewModel
    {
        ICommandExampleViewModel CommandExampleViewModel { get; }

        string Title { get; }
    }
}