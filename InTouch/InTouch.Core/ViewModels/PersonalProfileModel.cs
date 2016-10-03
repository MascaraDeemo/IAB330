using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class PersonalProfileModel
		: MvxViewModel
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