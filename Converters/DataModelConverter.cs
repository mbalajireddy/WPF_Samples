using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Converters
{
    public class DataModelConverter:System.Windows.Data.IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            StringBuilder _builder = new StringBuilder();
            foreach(object value in values)
            {
                _builder.Append(value.ToString()).Append(" ");
            }
            return _builder.ToString().Trim();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.ToString().Split(' ');
        }
    }
}
