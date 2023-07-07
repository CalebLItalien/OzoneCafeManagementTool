using CafeManagement.ViewModel;

namespace CafeManagement.View;

public partial class LifecyclePage : ContentPage
{
	public LifecyclePage(LifecycleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
