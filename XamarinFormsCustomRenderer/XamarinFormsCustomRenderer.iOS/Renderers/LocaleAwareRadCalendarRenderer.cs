//using Foundation;
//using XamarinFormsCustomRenderer.iOS.Renderers;
//using Telerik.XamarinForms.Input;
//using Telerik.XamarinForms.InputRenderer.iOS;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.iOS;

//[assembly: ExportRenderer(typeof(RadCalendar), typeof(LocaleAwareRadCalendarRenderer))]
//namespace XamarinFormsCustomRenderer.iOS.Renderers
//{
//    public class LocaleAwareRadCalendarRenderer : CalendarRenderer
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<RadCalendar> e)
//        {
//            base.OnElementChanged(e);

//            if (Control?.Calendar == null) return;

//            Control.Calendar.Locale = NSLocale.CurrentLocale;
//            Control.ReloadData();
//        }
//    }
//}
