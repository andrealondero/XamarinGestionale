using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App2.CustomViews;
using App2.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRendererIOS))]
namespace App2.iOS.Renderers
{
    public class CustomEntryRendererIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(229, 233, 234);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}