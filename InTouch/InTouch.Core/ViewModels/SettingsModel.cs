using MvvmCross.Core.ViewModels;
namespace InTouch.Core.ViewModels
{
	public class SettingsModel
	:MvxViewModel
	{
		private string notification = "default";
		public string Notification
		{
			get { return notification; }
			set { notification = value;}
		}
		private string vibration = "short";
		public string Vibration
		{
			get { return vibration; }
			set { vibration = value; }
		}
		private string light = "white";
		public string Light
		{
			get { return light; }
			set { light = value; }
		}

	}
}

