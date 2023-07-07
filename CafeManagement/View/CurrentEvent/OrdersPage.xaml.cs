using CafeManagement.ViewModel;

namespace CafeManagement.View;

public partial class OrdersPage : ContentPage
{
	public OrdersPage(OrdersViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
