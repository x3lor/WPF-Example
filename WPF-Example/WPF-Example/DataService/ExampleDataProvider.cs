using System.Collections.Generic;
using WPF_Example.Models;

namespace WPF_Example.DataService
{
    internal class ExampleDataProvider : IDataProvider
    {
        public IEnumerable<DataItem> GetAllData()
        {
            return new List<DataItem>
                   {
                       new TypeAItem(1,2),
                       new TypeAItem(3,200),
                       new TypeAItem(12,12),
                       new TypeBItem("bar"),
                       new TypeBItem("blubb"),
                       new TypeAItem(11,642),
                       new TypeAItem(156,982),
                       new TypeBItem("foo"),
                   };
        }
    }
}
