using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows;
using WeatherApp.Properties;

namespace WeatherApp.ViewModels.Services
{
    public static class OpenWeatherMapService
    {
        private static WebClient webClient;
        public static T GetDataFromAPI<T>(string name)
        {
            var cityId = Resources.CityId;
            var apikey = Resources.ApiKey;
            T deserializedObject;
            try
            {
                using (webClient = new WebClient())
                {
                    webClient.BaseAddress = Resources.BaseURL;
                    var query = $"{name}?q={cityId}&APPID={apikey}&units=metric";
                    var json = webClient.DownloadString(query);
                    deserializedObject = JsonConvert.DeserializeObject<T>(json);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            return deserializedObject;
        }
    }
}
