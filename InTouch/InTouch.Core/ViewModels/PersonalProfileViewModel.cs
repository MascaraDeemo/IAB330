using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class PersonalProfileViewModel
		: MvxViewModel
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