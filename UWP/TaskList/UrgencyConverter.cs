using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;
using TaskList.Interface;

namespace TaskList
{
    public class UrgencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string urgency = "";
            var urgKey = (UrgKey)value;

            switch (urgKey)
            {
                case UrgKey.Nonurgent:
                    {
                        urgency = "не срочно";
                        break;
                    }
                case UrgKey.Urgent:
                    {
                        urgency = "срочно";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return urgency;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
