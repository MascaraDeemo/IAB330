using Android.App;
using Android.OS;
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
	}
}
