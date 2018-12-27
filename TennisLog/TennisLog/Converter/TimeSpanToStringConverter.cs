using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TennisLog.Converter
{
    public class TimeSpanToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            try
            {
                TimeSpan timeSpan = (TimeSpan)value;
                var time = timeSpan.Hours + ":" + timeSpan.Minutes;

                var hours = timeSpan.Hours > 12 ? (timeSpan.Hours - 12) : timeSpan.Hours;
                var minutes = timeSpan.Minutes == 0 ? "00" : timeSpan.Minutes.ToString();
                return time = timeSpan.Hours > 12 ? hours + ":" + minutes + " PM" : hours + ":" + minutes + " AM";
                   
            }
            catch (Exception ex)
            {
                return DateTime.Today;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            throw new NotImplementedException();
        }
    }
}

