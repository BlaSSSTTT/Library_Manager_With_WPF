using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using PortableLibrary;

namespace LibraryUI.Convertors
{
    public class ImagePathConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var genre = (BookStatus) value;
            var uri = new Uri(string.Format(@"/Images/BookStatus/{0}.png", genre), UriKind.Relative);
            return new BitmapImage(uri);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
