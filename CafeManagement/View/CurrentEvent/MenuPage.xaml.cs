using CafeManagement.ViewModel;

namespace CafeManagement.View;

public partial class MenuPage : ContentPage
{
	public MenuPage(MenuViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}
