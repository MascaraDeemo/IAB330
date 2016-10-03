using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class ContactsModel
		: MvxViewModel
	{
		public IMvxCommand StatusButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<StatusModel>());
			}
		}
		public IMvxCommand SettingsButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<SettingsModel>());
			}
		}

	}
}