using CafeManagement.ViewModel;

namespace CafeManagement.View;

public partial class ArchivePage : ContentPage
{
	public ArchivePage(ScheduleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
