using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Interface;
using Windows.UI.Xaml.Data;

namespace TaskList
{
    public class ImportanceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string importance = "";
            var impKey = (ImpKey)value;

            switch (impKey)
            {
                case ImpKey.Important:
                    {
                        importance = "важно";
                        break;
                    }
                case ImpKey.Unimportant:
                    {
                        importance = "не важно";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return importance;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
