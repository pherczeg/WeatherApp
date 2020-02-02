using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace WeatherApp.Models
{
    public class ForecastWeatherData : WeatherData
    {
        private IEnumerable<WeatherData> list;
        [JsonProperty("list")]
        public IEnumerable<WeatherData> List
        {
            get
            {
                if (list == null)
                    return null;
                return list.Take(5);
            }
            set
            {
                list = value;
            }
        }
    }
}
