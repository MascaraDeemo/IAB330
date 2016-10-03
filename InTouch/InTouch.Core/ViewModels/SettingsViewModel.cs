using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class SettingsViewModel
	:MvxViewModel
	{
		public IMvxCommand BackButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<ContactsViewModel>());
			}
		}

	}
}

