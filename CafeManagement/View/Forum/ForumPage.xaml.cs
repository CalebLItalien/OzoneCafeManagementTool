using CafeManagement.ViewModel;
namespace CafeManagement.View;

public partial class ForumPage : ContentPage
{
	public ForumPage(ForumViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
