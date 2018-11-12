using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.Collections.Generic;
using WPF_Example.Models;

namespace WPF_Example.ViewModels.ListExample
{
    internal interface IListExampleViewModel : IViewModel
    {
        IEnumerable<DataItem> DataToDisplay { get; }
    }
}