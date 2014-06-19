using ListBoxBinding.Model;
using ListBoxBinding.View;
using System;
using System.Windows.Data;

namespace ListBoxBinding.Converter
{
    public class ViewProductConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is BookModel)
            {
                return new BookView();
            }
            else
            {
                return new MobilePhoneView();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

