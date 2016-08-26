using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace InTouch.Droid
{
    [Activity(
        Label = "InTouch"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
