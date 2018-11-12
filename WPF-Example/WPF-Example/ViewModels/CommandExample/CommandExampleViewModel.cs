using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.ComponentModel;

namespace WPF_Example.ViewModels.CommandExample
{
    internal class CommandExampleViewModel : ViewModel, ICommandExampleViewModel
    {
        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
