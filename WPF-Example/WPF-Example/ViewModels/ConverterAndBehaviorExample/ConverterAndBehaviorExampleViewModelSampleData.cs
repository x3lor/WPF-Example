using bytePassion.Library.Essentials.WpfTools.Positioning;
using System.ComponentModel;

#pragma warning disable 0067

namespace WPF_Example.ViewModels.ConverterAndBehaviorExample
{
    internal class ConverterAndBehaviorExampleViewModelSampleData: IConverterAndBehaviorExampleViewModel
    {
        public ConverterAndBehaviorExampleViewModelSampleData()
        {
            Size = new Size(new Width(200), new Height(100));
        }

        public Size Size { get; set; }

        public void Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}