using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace PracticalWork12.Converters
{
    internal class ChangeColorForClassPerson : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string classPerson = (string)value;
            switch (classPerson.Replace(" ", ""))
            {
                case "Воин":
                    return Brushes.Orange;
                case "Лучник":
                    return Brushes.Green;
                case "Mar":
                    return Brushes.Blue;
            }
            return Brushes.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
