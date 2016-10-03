using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class ContactsViewModel
		: MvxViewModel
	{
		public IMvxCommand StatusButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<StatusViewModel>());
			}
		}
		public IMvxCommand SettingsButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<SettingsViewModel>());
			}
		}

	}
}