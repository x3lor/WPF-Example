using bytePassion.Library.Essentials.Tools.FrameworkExtensions;
using bytePassion.Library.Essentials.WpfTools.Command;
using bytePassion.Library.Essentials.WpfTools.Command.Updater;
using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace WPF_Example.ViewModels.CommandExample
{
    internal class CommandExampleViewModel : ViewModel, ICommandExampleViewModel
    {
        private string someInput;

        public CommandExampleViewModel()
        {
            SomeInput = string.Empty;

            DoSomeAction = new Command(() => MessageBox.Show("Action"),
                                       () => SomeInput == "ACTION",
                                       new PropertyChangedCommandUpdater(this, nameof(SomeInput)));

            DoSomeActionWithParameter = new ParameterrizedCommand<string>(param => MessageBox.Show($"How cool is {param}?!"));
            // Can-Execute-Func and updater is here possible too (like the command above)
        }

        public ICommand DoSomeAction { get; }
        public ICommand DoSomeActionWithParameter { get; }

        public string SomeInput
        {
            get => someInput;
            set => PropertyChanged.ChangeAndNotify(this, ref someInput, value);
        }

        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
