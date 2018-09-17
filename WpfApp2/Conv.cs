using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace WpfApp2
{
    public class Conv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var d = System.Convert.ToString(value);//(KeyValuePair<string, string>)value;
            var thisData = Rep.Db.Where(e => e.v2 == d);
            if (d != String.Empty) return thisData; else return Rep.Db;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }



}
