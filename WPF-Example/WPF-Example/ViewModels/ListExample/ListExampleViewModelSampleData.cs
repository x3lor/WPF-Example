using System.Collections.Generic;
using System.ComponentModel;
using WPF_Example.Models;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.ListExample
{
    internal class ListExampleViewModelSampleData : IListExampleViewModel
    {
        public ListExampleViewModelSampleData()
        {
            DataToDisplay = new List<DataItem>
                            {
                                new TypeAItem(1,2),
                                new TypeAItem(3, 200),
                                new TypeAItem(12, 12),
                                new TypeBItem("bar")
                            };
        }

        public IEnumerable<DataItem> DataToDisplay { get; }

        public void Dispose() {}
        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}