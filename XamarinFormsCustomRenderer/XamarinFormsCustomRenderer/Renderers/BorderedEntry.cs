using Xamarin.Forms;

namespace XamarinFormsCustomRenderer.Renderers
{
    public class BorderedEntry : Entry
    {
        /// <summary>
        /// The BorderColor property
        /// </summary>
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(Entry), Color.Default);

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        /// <summary>
        /// The BorderColorActive property
        /// </summary>
        public static readonly BindableProperty BorderColorActiveProperty = BindableProperty.Create(nameof(BorderColorActive), typeof(Color), typeof(Entry), Color.Default);

        /// <summary>
        /// Gets or sets the color of the active border.
        /// </summary>
        /// <value>The color of the active border.</value>
        public Color BorderColorActive
        {
            get { return (Color)GetValue(BorderColorActiveProperty); }
            set { SetValue(BorderColorActiveProperty, value); }
        }

        /// <summary>
        /// The BorderHeight property
        /// </summary>
        public static readonly BindableProperty BorderHeightProperty = BindableProperty.Create(nameof(BorderHeight), typeof(double), typeof(Entry), 1.0);

        /// <summary>
        /// Gets or sets the height of the border.
        /// </summary>
        /// <value>The height of the border.</value>
        public double BorderHeight
        {
            get { return (double)GetValue(BorderHeightProperty); }
            set { SetValue(BorderHeightProperty, value); }
        }

        /// <summary>
        /// The BorderHeight property
        /// </summary>
        public static readonly BindableProperty HasBorderProperty = BindableProperty.Create(nameof(HasBorder), typeof(bool), typeof(Entry), false);

        /// <summary>
        /// Gets or sets the height of the border.
        /// </summary>
        /// <value>The height of the border.</value>
        public bool HasBorder
        {
            get { return (bool)GetValue(HasBorderProperty); }
            set { SetValue(HasBorderProperty, value); }
        }
    }
}
