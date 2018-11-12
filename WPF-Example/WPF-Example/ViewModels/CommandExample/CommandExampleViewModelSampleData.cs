using System.ComponentModel;

namespace WPF_Example.ViewModels.CommandExample
{
    internal class CommandExampleViewModelSampleData : ICommandExampleViewModel
    {
        public void Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}