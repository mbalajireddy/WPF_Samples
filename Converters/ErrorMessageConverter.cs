using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataBinding.Converters
{
    class ErrorMessageConverter:IValueConverter
    {
        //Source to Target
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //throw new NotImplementedException();
            return "Error : " + value.ToString();
        }

        //Target to Source
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //throw new NotImplementedException();
            return value; 
        }
    }
}
