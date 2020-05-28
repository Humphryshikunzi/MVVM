using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MvmIcommand.Converters
{
    class DateTimeToStringConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var trydate = (DateTimeOffset)value;
                return 0;
            }
            catch (Exception)
            {

              
                    var yesterday = DateTime.Now.AddHours(-4);
                    var now = DateTimeOffset.Now;
                    var difference = now - yesterday;
                    if (difference.TotalDays > 1)
                        return $"{difference.TotalDays:0} days ago";
                    else if (difference.TotalHours < 24)
                        return $"{difference.TotalHours:0} hours ago";
                    else if (difference.TotalMinutes < 60)
                        return $"{difference.TotalMinutes:0} minutes ago";
                    else if (difference.TotalSeconds < 60)
                        return $"{difference.TotalSeconds:0} seconds ago";
                    else
                    {
                        return "Yesterday";
                    }
               
            }
          
           

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTime.Now;
        }
    }
}
