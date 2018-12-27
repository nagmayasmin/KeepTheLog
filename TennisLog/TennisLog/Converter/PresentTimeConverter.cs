using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TennisLog.Converter
{
   public class PresentTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            try
            {
                return  (DateTime.Now - DateTime.Now.Date).ToString();
              //  return ts.GetValueOrDefault(TimeSpan.MinValue);

                         
            }
            catch (Exception ex)
            {
                return DateTime.Today;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            return DateTime.MinValue;
        }
    }
}
