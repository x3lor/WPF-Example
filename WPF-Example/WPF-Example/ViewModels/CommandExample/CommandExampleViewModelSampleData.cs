using System.ComponentModel;
using System.Windows.Input;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.CommandExample
{
    internal class CommandExampleViewModelSampleData : ICommandExampleViewModel
    {
        public CommandExampleViewModelSampleData()
        {
            SomeInput = "Example";
        }

        public ICommand DoSomeAction => null;
        public ICommand DoSomeActionWithParameter => null;
        public string SomeInput { get; set; }

        public void Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}