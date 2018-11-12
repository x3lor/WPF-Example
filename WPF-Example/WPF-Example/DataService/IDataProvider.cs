using System.Collections.Generic;
using WPF_Example.Models;

namespace WPF_Example.DataService
{
    internal interface IDataProvider
    {
        IEnumerable<DataItem> GetAllData();
    }
}