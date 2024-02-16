﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridLayout();
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
