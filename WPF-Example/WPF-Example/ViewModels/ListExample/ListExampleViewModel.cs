using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.Collections.Generic;
using System.ComponentModel;
using WPF_Example.DataService;
using WPF_Example.Models;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.ListExample
{
    internal class ListExampleViewModel : ViewModel, IListExampleViewModel
    {
        public ListExampleViewModel(IDataProvider dataProvider )
        {
            DataToDisplay = dataProvider.GetAllData();
        }

        public IEnumerable<DataItem> DataToDisplay { get; }

        protected override void CleanUp() { }
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
