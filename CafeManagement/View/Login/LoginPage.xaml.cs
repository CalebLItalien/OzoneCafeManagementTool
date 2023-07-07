using CafeManagement.ViewModel;
namespace CafeManagement.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
	}
}
