using CarCheckList.Services.Navigation;
using CarCheckList.ViewModels;
using CarCheckList.Views;
using Microsoft.Extensions.Logging;

namespace CarCheckList;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<INavigationService, NavigationService>();

		builder.Services.AddSingleton<ChecklistViewModel>();
		builder.Services.AddSingleton<ChecklistPage>();

		builder.Services.AddSingleton<HistoryViewModel>();
		builder.Services.AddSingleton<HistoryPage>();
		
		builder.Services.AddSingleton<CarInfoViewModel>();
		builder.Services.AddSingleton<CarInfoPage>();

		return builder.Build();
	}
}
