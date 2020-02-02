using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WeatherApp.Models.Helper;

namespace WeatherApp.Models
{
    public class Temperature : NotifyProperty
    {
        

        private double temp;
        [JsonProperty("temp")]
        public double Temp
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
                NotifyPropertyChanged("Temp");
            }
        }

        private double tempMin;
        [JsonProperty("temp_min")]
        public double TempMin

        {
            get
            {
                return tempMin;
            }
            set
            {
                tempMin = value;
                NotifyPropertyChanged("TempMin");
            }
        }

        private double tempMax;
        [JsonProperty("temp_max")]
        public double TempMax

        {
            get
            {
                return tempMax;
            }
            set
            {
                tempMax = value;
                NotifyPropertyChanged("TempMax");
            }
        }

        private double humidity;
        [JsonProperty("humidity")]
        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                humidity = value;
                NotifyPropertyChanged("Humidity");
            }
        }

        public SolidColorBrush ColorBrush
        {
            get 
            {
                Color color = Colors.DarkBlue;
                if (Temp >= 40)
                    color = Colors.DarkRed;
                else if (Temp >= 30)
                    color = Colors.Red;
                else if (Temp >= 25)
                    color = Colors.DarkOrange;
                else if (Temp >= 20)
                    color = Colors.Orange;
                else if (Temp >= 15)
                    color = Colors.Yellow;
                else if (Temp >= 10)
                    color = Colors.LightYellow;
                else if (Temp >= 5)
                    color = Colors.LightBlue;
                else if (Temp >= 0)
                    color = Colors.Blue;
                return new SolidColorBrush(color);
            }
        }

        public Visibility IsNegative
        {
            get
            {
                if (temp < 0)
                    return Visibility.Collapsed;
                else return Visibility.Visible;
            }
        }

    }
}
