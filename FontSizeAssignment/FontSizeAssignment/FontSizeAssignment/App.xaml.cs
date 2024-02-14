using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontSizeAssignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new page1();
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
