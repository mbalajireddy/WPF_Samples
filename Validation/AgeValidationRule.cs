using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataBinding.Validation
{
    public class AgeValidationRule:ValidationRule
    {
        public int Min { get; set; }

        public int Max { get; set; }
        
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            
            //throw new NotImplementedException();
            //string value = value as string;
            int _value;
            if(Int32.TryParse(value.ToString(),out _value))
            {
                if(_value > Min && _value < Max)
                {
                    return new ValidationResult(true, "");
                }
                else
                {
                    string errorContent = string.Format("Value must be in the range of {0} - {1}", Min, Max);
                    return new ValidationResult(false, errorContent);
                }
            }
            return new ValidationResult(false, "Age must be a number");
        }
    }
}
