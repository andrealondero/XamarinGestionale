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

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRendererIOS))]
namespace App2.iOS.Renderers
{
    public class CustomButtonRendererIOS : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(45, 129, 131);
            }
        }
    }
}