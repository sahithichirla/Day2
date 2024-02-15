using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArithmeticOperations
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calculator();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
