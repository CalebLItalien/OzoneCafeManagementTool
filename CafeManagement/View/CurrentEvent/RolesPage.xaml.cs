using CafeManagement.ViewModel;

namespace CafeManagement.View;

public partial class RolesPage : ContentPage
{
	public RolesPage(RolesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
