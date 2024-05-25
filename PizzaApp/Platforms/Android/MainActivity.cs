using Android.App;
using Android.Content.PM;
using Android.OS;

namespace PizzaApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this?.Window?.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#ffffff"));
            this?.Window?.SetStatusBarColor(Android.Graphics.Color.ParseColor("#0A1E2E"));
        }

    }
}
