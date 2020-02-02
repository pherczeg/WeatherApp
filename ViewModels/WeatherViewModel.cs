using Caliburn.Micro;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.Models;
using WeatherApp.Properties;
using WeatherApp.ViewModels.Services;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel : Screen
    {
        private ICommand refreshCommand;

        public ICommand RefreshCommand
        {
            get
            {
                if (refreshCommand == null)
                {
                    refreshCommand = new RelayCommand(() => { this.GetData(); }, false);
                }
                return refreshCommand;
            }
        }

        private CurrentWeatherData currentWeatherData;

        public CurrentWeatherData CurrentWeatherData
        {
            get { return currentWeatherData; }
            set { currentWeatherData = value; }
        }

        private ForecastWeatherData forecastWeatherData;

        public ForecastWeatherData ForecastWeatherData
        {
            get { return forecastWeatherData; }
            set { forecastWeatherData = value; }
        }

        public WeatherViewModel()
        {
            GetData();
        }

        private void GetData()
        {
            CurrentWeatherData = OpenWeatherMapService.GetDataFromAPI<CurrentWeatherData>("weather");
            ForecastWeatherData = OpenWeatherMapService.GetDataFromAPI<ForecastWeatherData>("forecast");
        }
    }

}
