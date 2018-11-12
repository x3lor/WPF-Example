namespace WPF_Example.Models
{
    internal class TypeAItem : DataItem
    {
        public TypeAItem(int number1, int number2) 
            : base(ItemType.TypeA)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public int Number1 { get; }
        public int Number2 { get; }
    }
}