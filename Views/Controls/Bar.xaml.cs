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

        public static readonly DependencyProperty ImageUrlProperty =
         DependencyProperty.Register("ImageUrl", typeof(string), typeof(Bar), new
            UIPropertyMetadata("n/a", new PropertyChangedCallback(OnImageUrlChanged)));

        public string ImageUrl
        {
            get { return (string)GetValue(ImageUrlProperty); }
            set { SetValue(ImageUrlProperty, value); }
        }

        private static void OnImageUrlChanged(DependencyObject d,
          DependencyPropertyChangedEventArgs e)
        {
            Bar bar = d as Bar;
            bar.OnImageUrlChanged(e);
        }

        private void OnImageUrlChanged(DependencyPropertyChangedEventArgs e)
        {
            //img.Source.SetValue(
        }



        public static readonly DependencyProperty SetTextProperty =
         DependencyProperty.Register("SetText", typeof(string), typeof(Bar), new
            UIPropertyMetadata("n/a", new PropertyChangedCallback(OnSetTextChanged)));

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


        public double Value
        {
            get
            {
                return (double)this.GetValue(ValueProperty);
            }
            set
            {
                this.SetValue(ValueProperty, value);
                NotifyPropertyChanged("Value");
            }
        }
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
          "Value", typeof(double), typeof(Bar), new UIPropertyMetadata(0.0, new PropertyChangedCallback(OnValueChanged)));


        private static void OnValueChanged(DependencyObject d,
          DependencyPropertyChangedEventArgs e)
        {
            Bar bar = d as Bar;
            bar.OnValueChanged(e);
        }

        private void OnValueChanged(DependencyPropertyChangedEventArgs e)
        {
            var newValue = (double)e.NewValue;
            border.Height = 250 * (newValue/45) +100;
        }

        public Brush Color
        {
            get
            {
                return (Brush)this.GetValue(ColorProperty);
            }
            set
            {
                this.SetValue(ColorProperty, value);
                NotifyPropertyChanged("Color");
            }
        }
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
          "Color", typeof(SolidColorBrush), typeof(Bar), new UIPropertyMetadata(default(Brush),new PropertyChangedCallback(OnColorChanged)));

        private static void OnColorChanged(DependencyObject d,
          DependencyPropertyChangedEventArgs e)
        {
            Bar bar = d as Bar;
            bar.OnColorChanged(e);
        }

        private void OnColorChanged(DependencyPropertyChangedEventArgs e)
        {
            var newValue = (Brush)e.NewValue;
            border.Background = newValue;
        }

        public Bar()
        {
            InitializeComponent();
            //this.DataContext = this;
            //Color = Brushes.Black;
        }

        //private void UserControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    UpdateBarHeight();
        //}

        //private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    UpdateBarHeight();
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}

