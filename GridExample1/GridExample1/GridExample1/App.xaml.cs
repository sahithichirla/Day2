﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridExample1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DialPad();
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
