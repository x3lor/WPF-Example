using bytePassion.Library.Essentials.Tools.FrameworkExtensions;
using bytePassion.Library.Essentials.WpfTools.Positioning;
using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;
using System.ComponentModel;

namespace WPF_Example.ViewModels.ConverterAndBehaviorExample
{
    internal class ConverterAndBehaviorExampleViewModel: ViewModel, IConverterAndBehaviorExampleViewModel
    {
        private Size size;

        public ConverterAndBehaviorExampleViewModel()
        {
            size = Size.Zero;
        }

        public Size Size
        {
            get => size;
            set => PropertyChanged.ChangeAndNotify(this, ref size, value);
        }

        protected override void CleanUp() {}
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
