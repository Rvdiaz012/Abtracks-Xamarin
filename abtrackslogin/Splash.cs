﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace abtrackslogin
{
    [Activity(Label = "Abtracks", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory = true)]
    public class Splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Display Splash Screen for 4 Sec
            // Set our view from the "MainActivity" StartActivity
            StartActivity(typeof(MainActivity));
        }
    }
}