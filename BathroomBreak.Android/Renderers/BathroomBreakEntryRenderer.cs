﻿using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using BathroomBreak.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BathroomBreak.CustomControls.BackgroundBreakEntry), typeof(BathroomBreakEntryRenderer))]
namespace BathroomBreak.Droid.Renderers
{
    public class BathroomBreakEntryRenderer : EntryRenderer
    {
        public BathroomBreakEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
            else
                Control.Background.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
        }
    }
}
