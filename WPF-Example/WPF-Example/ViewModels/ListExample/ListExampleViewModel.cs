using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.ComponentModel;

namespace WPF_Example.ViewModels.ListExample
{
    internal class ListExampleViewModel : ViewModel, IListExampleViewModel
    {
        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
