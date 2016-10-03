using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class StatusModel
		: MvxViewModel
	{
		public IMvxCommand BackButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<ContactsModel>());
			}
		}
		public IMvxCommand UpdateStatusButton
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<ContactsModel>());
			}
		}

	}
}