namespace WPF_Example.Models
{
    internal abstract class DataItem
    {
        protected DataItem(ItemType type)
        {
            Type = type;
        }

        public ItemType Type { get; }
    }
}
