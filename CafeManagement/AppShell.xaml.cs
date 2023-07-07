using CafeManagement.View;
namespace CafeManagement;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ArchivePage), typeof(ArchivePage));
		Routing.RegisterRoute(nameof(LifecyclePage), typeof(LifecyclePage));
		Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
		Routing.RegisterRoute(nameof(OrdersPage), typeof(OrdersPage));
		Routing.RegisterRoute(nameof(RolesPage), typeof(RolesPage));
		Routing.RegisterRoute(nameof(ForumPage), typeof(ForumPage));
		Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
		Routing.RegisterRoute(nameof(SchedulePage), typeof(SchedulePage));
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
	}
}

