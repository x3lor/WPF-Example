using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.Windows.Input;

namespace WPF_Example.ViewModels.CommandExample
{
    internal interface ICommandExampleViewModel : IViewModel
    {
        ICommand DoSomeAction { get; }
        ICommand DoSomeActionWithParameter { get; }
        
        string SomeInput { get; set; }
    }
}