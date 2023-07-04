using CafeManagement.ViewModel;

namespace CafeManagement;

public partial class RolesPage : ContentPage
{
	public RolesPage(RolesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
