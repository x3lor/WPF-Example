using bytePassion.Library.Essentials.WpfTools.Positioning;
using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;

namespace WPF_Example.ViewModels.ConverterAndBehaviorExample
{
    internal interface IConverterAndBehaviorExampleViewModel : IViewModel
    {
        Size Size { get; set; }        
    }
}