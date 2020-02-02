using Newtonsoft.Json;


namespace WeatherApp.Models
{
    using System.ComponentModel;
    using WeatherApp.Models.Helper;

    public class WeatherData : NotifyProperty
    {
        private Icon[] weather;
        [JsonProperty("weather")]
        public Icon[] Weather
        { 
            get 
            { 
                return weather; 
            } 
            set 
            { 
                weather = value; 
                NotifyPropertyChanged("Weather");
            } 
        }

        private Temperature temperature;
        [JsonProperty("main")]
        public Temperature Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
                NotifyPropertyChanged("Temperature");
            }
        }

        public override string ToString()
        {
            return Temperature.Temp.ToString();
        }
    }
}