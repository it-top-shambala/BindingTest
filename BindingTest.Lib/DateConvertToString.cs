using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BindingTest.Lib
{
    public class DateConvertToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return (value is DateTime time ? time : default).ToString("yyyy.MM.dd");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}