using CoreAnimation;
using CoreGraphics;

namespace XamarinFormsCustomRenderer.iOS.Renderers
{
    public sealed class BorderedLayer : CALayer
    {
        public BorderedLayer(CGColor borderBolor, double borderHeight, double height, double width)
        {
            BackgroundColor = borderBolor;
            
            Frame = new CGRect(0, height, width, borderHeight);
        }
    }
}
