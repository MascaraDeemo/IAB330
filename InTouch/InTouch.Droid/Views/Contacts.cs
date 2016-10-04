using Android.App;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;
using MvvmCross.Droid.Views;

namespace InTouch.Droid.Views
{
	[Activity(Label = "Contacts")]
	public class Contacts : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Status);
		}
        public static MobileServiceClient MobileService = new MobileServiceClient
    ("https://intouch2cg.azurewebsites.net"
    );
        public class TodoItem {
            public string Id { get; set; }
            public string Text { get; set; }
        }
    }

}
