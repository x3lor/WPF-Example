using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using WPF_Example.ViewModels.CommandExample;
using WPF_Example.ViewModels.ConverterAndBehaviorExample;
using WPF_Example.ViewModels.ListExample;

namespace WPF_Example.ViewModels.MainWindow
{
    internal interface IMainWindowViewModel : IViewModel
    {
        ICommandExampleViewModel CommandExampleViewModel { get; }
        IConverterAndBehaviorExampleViewModel ConverterAndBehaviorExampleViewModel { get; }
        IListExampleViewModel ListExampleViewModel { get; }

        string Title { get; }
    }
}