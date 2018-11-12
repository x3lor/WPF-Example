using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;

namespace WPF_Example.ViewModels.MainWindow
{
    internal interface IMainWindowViewModel : IViewModel
    {
        string Title { get; }
    }
}