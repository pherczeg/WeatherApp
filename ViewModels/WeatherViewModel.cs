using Caliburn.Micro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Properties;
using WeatherApp.ViewModels.Services;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel : Screen
    {

        public string Sample
        {
            get { return "asdfowe"; }
        }
        //private CurrentWeatherData currentWeatherData;

        //public CurrentWeatherData CurrentWeatherData
        //{
        //    get { return currentWeatherData; }
        //    set { currentWeatherData = value; }
        //}

        //private ForecastWeatherData forecastWeatherData;

        //public ForecastWeatherData ForecastWeatherData
        //{
        //    get { return forecastWeatherData; }
        //    set { forecastWeatherData = value; }
        //}

        public WeatherViewModel()
        {
            //CurrentWeatherData = OpenWeatherMapService.GetDataFromAPI<CurrentWeatherData>("weather");
            //ForecastWeatherData = OpenWeatherMapService.GetDataFromAPI<ForecastWeatherData>("forecast");
        }
    }

}
