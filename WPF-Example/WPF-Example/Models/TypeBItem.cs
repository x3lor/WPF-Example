namespace WPF_Example.Models
{
    internal class TypeBItem : DataItem
    {
        public TypeBItem(string content)
            : base(ItemType.TypeB)
        { 
            Content = content;          
        }

        public string Content { get;  }
    }
}