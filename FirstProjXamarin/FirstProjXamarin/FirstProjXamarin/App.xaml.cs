using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstProjXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PostComment();
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
