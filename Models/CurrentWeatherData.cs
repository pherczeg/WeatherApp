using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class CurrentWeatherData : WeatherData
    {
        [JsonProperty("name")]
        public string Location { get; set; }
    }
}
