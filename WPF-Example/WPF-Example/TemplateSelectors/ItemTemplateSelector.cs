using System.Windows;
using System.Windows.Controls;
using WPF_Example.Models;

namespace WPF_Example.TemplateSelectors
{
    internal class ItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ItemATemplate { get; set; }
        public DataTemplate ItemBTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var dataItem = (DataItem) item;

            switch (dataItem?.Type)
            {
                case ItemType.TypeA: return ItemATemplate;
                case ItemType.TypeB: return ItemBTemplate;
                case null: default: return null;
            }
        }
    }
}

