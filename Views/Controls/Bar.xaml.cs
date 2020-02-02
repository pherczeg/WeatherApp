using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Models.Helper;

namespace WeatherApp.Views.Controls
{
    /// <summary>
    /// Interaction logic for Bar.xaml
    /// </summary>
    public partial class Bar : UserControl
    {

        public static readonly DependencyProperty SetTextProperty =
         DependencyProperty.Register("SetText", typeof(string), typeof(Bar), new
            UIPropertyMetadata("sd", new PropertyChangedCallback(OnSetTextChanged)));

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }



        private static void OnSetTextChanged(DependencyObject d,
          DependencyPropertyChangedEventArgs e)
        {
            Bar bar = d as Bar;
            bar.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            textblock.Text = e.NewValue.ToString();
        }
        //public double Value
        //{
        //    get
        //    {
        //        return (double)this.GetValue(ValueProperty);
        //    }
        //    set
        //    {
        //        this.SetValue(ValueProperty, value);
        //        UpdateBarHeight();
        //        NotifyPropertyChanged("Value");
        //    }
        //}
        //public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
        //  "Value", typeof(double), typeof(Bar), new PropertyMetadata(0.0));


        //public Brush Color
        //{
        //    get
        //    {
        //        return (Brush)this.GetValue(ColorProperty);
        //    }
        //    set
        //    {
        //        this.SetValue(ColorProperty, value);
        //        NotifyPropertyChanged("Color");
        //    }
        //}
        //public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
        //  "Color", typeof(SolidColorBrush), typeof(Bar), new PropertyMetadata(default(Brush)));

        //public double MaxValue
        //{
        //    get
        //    {
        //        return (double)this.GetValue(ColorProperty);
        //    }
        //    set
        //    {
        //        this.SetValue(ColorProperty, value);
        //        UpdateBarHeight();
        //        NotifyPropertyChanged("MaxValue");
        //    }
        //}
        //public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(
        //  "MaxValue", typeof(double), typeof(Bar), new PropertyMetadata(default(double)));


        //private double barHeight;
        //public double BarHeight
        //{
        //    get { return barHeight; }
        //    private set { barHeight = value; NotifyPropertyChanged("BarHeight"); }
        //}

        //private void UpdateBarHeight()
        //{
        //    if (MaxValue > 0)
        //    {
        //        var percent = (Value * 100) / MaxValue;
        //        BarHeight = (percent * this.ActualHeight) / 100;
        //    }
        //}


        //public Bar()
        //{
        //    InitializeComponent();
        //    this.DataContext = this;
        //    Color = Brushes.Black;
        //}

        //private void UserControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    UpdateBarHeight();
        //}

        //private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    UpdateBarHeight();
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged(string info)
        //{
        //    //if (PropertyChanged != null)
        //    //    PropertyChanged(this, new PropertyChangedEventArgs(info));
        //}
    }
}

