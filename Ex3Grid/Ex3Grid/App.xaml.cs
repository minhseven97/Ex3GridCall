﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ex3Grid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Grid();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
