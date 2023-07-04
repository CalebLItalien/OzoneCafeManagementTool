using CafeManagement.ViewModel;

namespace CafeManagement;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}
