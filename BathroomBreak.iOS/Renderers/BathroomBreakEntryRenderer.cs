using BathroomBreak.iOS.Renderers;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BathroomBreak.CustomControls.BackgroundBreakEntry), typeof(BathroomBreakEntryRenderer))]
namespace BathroomBreak.iOS.Renderers
{
    public class BathroomBreakEntryRenderer : EntryRenderer
    {
        private CALayer _line;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            _line = null;

            if (Control == null || e.NewElement == null)
                return;

            Control.BorderStyle = UITextBorderStyle.None;

            _line = new CALayer
            {
                BorderColor = UIColor.FromRGB(174, 174, 174).CGColor,
                BackgroundColor = UIColor.FromRGB(174, 174, 174).CGColor,
                Frame = new CGRect(0, Frame.Height + (Frame.Height/2), Frame.Width * 2, 1f)
            };

            Control.Layer.AddSublayer(_line);
        }
    }
}
