using CafeManagement.ViewModel;
namespace CafeManagement;

public partial class SchedulePage : ContentPage
{
	public SchedulePage(ScheduleViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}
