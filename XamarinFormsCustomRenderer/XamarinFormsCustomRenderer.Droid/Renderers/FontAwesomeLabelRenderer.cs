using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsCustomRenderer.Droid.Renderers;
using XamarinFormsCustomRenderer.Renderers;

[assembly: ExportRenderer(typeof(FontAwesomeLabel), typeof(FontAwesomeLabelRenderer))]
namespace XamarinFormsCustomRenderer.Droid.Renderers
{
    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control == null || Element == null || e.OldElement != null) return;

            Typeface font = Typeface.CreateFromAsset(Context.Assets, "Fonts/FontAwesome.ttf");
            Control.Typeface = font;
        }
    }
}