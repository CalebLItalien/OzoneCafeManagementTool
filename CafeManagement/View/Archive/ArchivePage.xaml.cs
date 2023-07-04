using CafeManagement.ViewModel;

namespace CafeManagement;

public partial class ArchivePage : ContentPage
{
	public ArchivePage(ScheduleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
