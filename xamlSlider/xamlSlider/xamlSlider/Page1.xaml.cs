using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace xamlSlider
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //slider1.Value = 0.5;
            

        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = string.Format("Value is {0:F2}", e.NewValue);

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label2.Text = "Entered Text: " + e.NewTextValue;
        }

        private void Slider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slider2.Value = e.NewValue;
            label3.Text = slider2.Value.ToString();
        }
    }
}