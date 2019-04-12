using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App2.CustomViews;
using App2.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomRendererEntryAndroid))]
namespace App2.Droid.Renderers
{
    class CustomRendererEntryAndroid : EntryRenderer
    {
        public CustomRendererEntryAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGray);
                Control.SetTextColor(global::Android.Graphics.Color.LightCoral);
            }
        }
    }
}