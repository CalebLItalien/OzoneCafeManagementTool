using CafeManagement.ViewModel;
using CafeManagement.View;
using Microsoft.Extensions.Logging;

namespace CafeManagement;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		//--- SCHEDULE ---\\
		builder.Services.AddTransient<SchedulePage>();
		builder.Services.AddTransient<ScheduleViewModel>();
        //----------------\\

        //--- PROFILE ---\\
        builder.Services.AddTransient<ProfilePage>();
		builder.Services.AddTransient<ProfileViewModel>();
        //----------------\\

		//--- ARCHIVE --- \\
        builder.Services.AddTransient<ArchivePage>();
		builder.Services.AddTransient<ArchiveViewModel>();
        //----------------\\

		//--- FORUM ---\\
        builder.Services.AddTransient<ForumPage>();
		builder.Services.AddTransient<ForumViewModel>();
		//-------------\\

		//--- CURRENT_EVENT ---\\
		builder.Services.AddTransient<MenuPage>();
		builder.Services.AddTransient<MenuViewModel>();
		builder.Services.AddTransient<OrdersPage>();
		builder.Services.AddTransient<OrdersViewModel>();
		builder.Services.AddTransient<RolesPage>();
		builder.Services.AddTransient<RolesViewModel>();
		builder.Services.AddTransient<LifecyclePage>();
		builder.Services.AddTransient<LifecycleViewModel>();
		//---------------------\\

		//--- LOGIN ---\\
		builder.Services.AddTransient<LoginPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

