using Databinding3_ClassLibrary.Constants;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Databinding3_ClassLibrary.Converters
{
    [ValueConversion(typeof(double), typeof(double))]
    public class LabelFontSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double FontSizeValue)
            {
                if (FontSizeValue > 0)
                {
                    return System.Convert.ToDouble(Const.CurrentMaxLabelFontSizeValue + 1 - FontSizeValue);
                }
                else
                {
                    return System.Convert.ToDouble(Const.MinLabelFontSizeValue);
                }
            }
            else
            {
                return System.Convert.ToDouble(-1);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
