﻿using System;
using InstagramApiSharp.Classes.Models;
using Windows.UI.Xaml.Data;


namespace Minista.Converters
{
    class NumericToSeparatorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return "";
            if (value is int data && !string.IsNullOrEmpty(data.ToDigits()))
                return $"{data.ToDigits()}";
            if (value is long data2 && !string.IsNullOrEmpty(data2.ToDigits()))
                return $"{data2.ToDigits()}";
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
