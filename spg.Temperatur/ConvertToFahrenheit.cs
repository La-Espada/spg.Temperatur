using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace spg.Temperatur
{
    public class ConvertToFahrenheit : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            double retValue = (double)value;
           
                retValue = (retValue * 9 / 5) + 32;
               
                 return Math.Round(retValue, 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

       
    }

