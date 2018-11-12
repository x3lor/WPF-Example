using System.ComponentModel;

namespace WPF_Example.ViewModels.ConverterAndBehaviorExample
{
    internal class ConverterAndBehaviorExampleViewModelSampleData: IConverterAndBehaviorExampleViewModel
    {
        public ConverterAndBehaviorExampleViewModelSampleData()
        {
            SizeOutput = "100 x 200 px";
        }

        public string SizeOutput { get; set; }

        public void                              Dispose() { }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}