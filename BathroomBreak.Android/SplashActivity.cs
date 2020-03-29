
using System;
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

namespace BathroomBreak.Droid
{
    [Activity(Label = "SplashActivity", Icon = "@mipmap/icon", Theme = "@style/splash_screen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            this.Window.AddFlags(WindowManagerFlags.Fullscreen); //to show
            this.Window.ClearFlags(WindowManagerFlags.Fullscreen); //to hide
            // Name of the MainActivity theme you had there before.
            // Or you can use global::Android.Resource.Style.ThemeHoloLight
            base.SetTheme(Resource.Style.MainTheme);

            base.OnCreate(bundle);
        }

        protected override void OnResume()
        {
            base.OnResume();

            Thread.Sleep(5000);

            StartActivity(typeof(MainActivity));
        }
    }
}
