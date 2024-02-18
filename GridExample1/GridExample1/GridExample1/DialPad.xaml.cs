using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridExample1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DialPad : ContentPage
    {
        public DialPad()
        {
            InitializeComponent();
        }
        void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                phoneNumberEntry.Text += button.Text;
                phoneNumberLabel.Text=phoneNumberEntry.Text;

            }
        }

        void DialButton_Clicked(object sender, EventArgs e)
        {
            // Implement your dialing logic here
            // For simplicity, let's just display an alert with the dialed number

            DisplayAlert("Dialing", "Dialing " + phoneNumberLabel.Text, "OK");

        }


    }
}