using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytePassion.Library.Essentials.WpfTools.ViewModelBase.Standard;

namespace WPF_Example.ViewModels.ConverterAndBehaviorExample
{
    internal class ConverterAndBehaviorExampleViewModel: ViewModel, IConverterAndBehaviorExampleViewModel
    {
        public string SizeOutput { get; set; }

        protected override void CleanUp() {}
        public override event PropertyChangedEventHandler PropertyChanged;
    }
}
