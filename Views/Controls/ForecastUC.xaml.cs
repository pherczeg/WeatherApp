using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherApp.Views.Controls
{
    /// <summary>
    /// Interaction logic for ForecastUC.xaml
    /// </summary>
    public partial class ForecastUC : UserControl
    {
        public ForecastUC()
        {
            InitializeComponent();
        }
    }
    public class DoubleToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int retVal = 0;
            if (value is double)
            {
                var temp = (double)value * 10;
                retVal = (int)temp;
            }
            return retVal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
