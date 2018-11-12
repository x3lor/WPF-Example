using System.ComponentModel;

namespace WPF_Example.ViewModels.ListExample
{
    internal class ListExampleViewModelSampleData : IListExampleViewModel
    {
        public void Dispose() {}
        public event PropertyChangedEventHandler PropertyChanged;
    }
}