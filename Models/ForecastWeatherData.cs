using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class ForecastWeatherData
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
