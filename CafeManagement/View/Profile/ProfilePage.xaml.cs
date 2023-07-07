using CafeManagement.ViewModel;

namespace CafeManagement.View;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}
