using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class SettingsModel
	:MvxViewModel
	{
		public IMvxCommand BackButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<ContactsModel>());
			}
		}

	}
}

