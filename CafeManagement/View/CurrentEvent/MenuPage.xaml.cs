using CafeManagement.ViewModel;

namespace CafeManagement;

public partial class MenuPage : ContentPage
{
	public MenuPage(MenuViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
