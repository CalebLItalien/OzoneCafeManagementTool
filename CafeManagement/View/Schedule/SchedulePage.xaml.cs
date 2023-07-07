using CafeManagement.ViewModel;
namespace CafeManagement.View;

public partial class SchedulePage : ContentPage
{
	public SchedulePage(ScheduleViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}
