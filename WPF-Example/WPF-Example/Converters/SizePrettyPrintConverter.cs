using bytePassion.Library.Essentials.WpfTools.ConverterBase;
using bytePassion.Library.Essentials.WpfTools.Positioning;
using System;
using System.Globalization;

namespace WPF_Example.Converters
{
    internal class SizePrettyPrintConverter : GenericValueConverter<Size, string>
    {
        protected override string Convert(Size value, CultureInfo culture)
        {
            return $"{Math.Round(value.Width)} x {Math.Round(value.Height)} px";
        }
    }
}
