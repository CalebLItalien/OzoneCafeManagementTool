using CafeManagement.ViewModel;
namespace CafeManagement;

public partial class ForumPage : ContentPage
{
	public ForumPage(ForumViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
