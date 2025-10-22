using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PracticalWork12.Converters
{
    internal class TeamsSelect : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int IDteam = (int)value;
            var teamusers = Helpers.Helpers.DB.CommandUser.Where(x => x.CommandID == IDteam);
            return teamusers.ToList();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
