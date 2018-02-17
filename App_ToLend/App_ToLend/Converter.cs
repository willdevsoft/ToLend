using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_ToLend
{
    public class StringToColorConverter : Xamarin.Forms.IValueConverter
    {

        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string && value != null)
            {
                string s = (string)value;
                switch (s)
                {
                    case "RED":
                        return Color.Red;
                    case "BLUE":
                        return Color.Blue;
                    default:
                        return Color.Black;
                }

            }
            return Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
