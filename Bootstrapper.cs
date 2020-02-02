using Caliburn.Micro;
using System.Windows;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    public class Bootstrapper : BootstrapperBase
    {
        #region Constructor
        public Bootstrapper()
        {
            Initialize();
        }
        #endregion

        #region Overrides
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<WeatherViewModel>();
        }
        #endregion
    }
}
