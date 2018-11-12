using System.ComponentModel;

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        public MainWindowViewModelSampleData()
        {
            Title = "Design-Time-Title";
        }

        public string Title { get; }

        public void                              Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}