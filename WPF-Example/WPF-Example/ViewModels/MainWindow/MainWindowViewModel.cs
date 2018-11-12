using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;

namespace WPF_Example.ViewModels.MainWindow
{
    internal class MainWindowViewModel : ViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(string title)
        {
            Title = title;
        }

        public string Title { get; }
        
        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
