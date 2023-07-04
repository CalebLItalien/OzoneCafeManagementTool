using CafeManagement.ViewModel;

namespace CafeManagement;

public partial class OrdersPage : ContentPage
{
	public OrdersPage(OrdersViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
