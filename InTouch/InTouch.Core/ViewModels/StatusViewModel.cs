using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class StatusViewModel
		: MvxViewModel
	{
		public IMvxCommand BackButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<ContactsViewModel>());
			}
		}
		public IMvxCommand UpdateStatusButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<ContactsViewModel>());
			}
		}

	}
}