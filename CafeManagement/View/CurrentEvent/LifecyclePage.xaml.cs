using CafeManagement.ViewModel;

namespace CafeManagement;

public partial class LifecyclePage : ContentPage
{
	public LifecyclePage(LifecycleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
