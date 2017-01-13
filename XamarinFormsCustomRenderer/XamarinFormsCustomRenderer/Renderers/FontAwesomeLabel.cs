using Xamarin.Forms;

namespace XamarinFormsCustomRenderer.Renderers
{
    public class FontAwesomeLabel : Label
    {
        public FontAwesomeLabel()
        {
            FontFamily = Device.OnPlatform(
            "FontAwesome",
            null,
            null);
        }
    }
}
