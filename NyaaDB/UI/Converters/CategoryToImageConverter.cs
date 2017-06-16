using NyaaDB.Api.AnimeDB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NyaaDB.UI.Converters
{
    public class CategoryToImageConverter : IValueConverter
    {
        private readonly Dictionary<int, string> CategoryDic = new Dictionary<int, string>() {
            { 1, "../../Resources/Categories/www-23.png" },
            { 2, "../../Resources/Categories/www-24.png"},
            { 3, "../../Resources/Categories/www-14.png"},
            { 4, "../../Resources/Categories/www-15.png"},
            { 5, "../../Resources/Categories/www-37.png"},
            { 6, "../../Resources/Categories/www-11.png"},
            { 7, "../../Resources/Categories/www-12.png"},
            { 8, "../../Resources/Categories/www-13.png"},
            { 9, "../../Resources/Categories/www-19.png"},
            { 10, "../../Resources/Categories/www-22.png"},
            { 11, "../../Resources/Categories/www-20.png"},
            { 12, "../../Resources/Categories/www-32.png"},
            { 13, "../../Resources/Categories/www-38.png"},
            { 14, "../../Resources/Categories/www-39.png"},
            { 15, "../../Resources/Categories/www-18.png"},
            { 16, "../../Resources/Categories/www-17.png"},
            { 18, "../../Resources/Categories/www-21.png"}
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cat = 0;
            Int32.TryParse(value as string, out cat);

            var res = string.Empty;
            CategoryDic.TryGetValue(cat, out res);
            return res;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
