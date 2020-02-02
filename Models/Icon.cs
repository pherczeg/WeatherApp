using Newtonsoft.Json;
using WeatherApp.Models.Helper;

namespace WeatherApp.Models
{
    public class Icon : NotifyProperty
    {
        private string iconID;
        [JsonProperty("icon")]
        public string IconID
        {
            get
            {
                return iconID;
            }
            set
            {
                iconID = value;
                NotifyPropertyChanged("Temperature");
            }
        }


    }
}