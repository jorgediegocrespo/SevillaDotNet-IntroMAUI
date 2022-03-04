namespace SevillaDotNet;

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
			})
			.Services
				.AddSingleton<IAlertDialogService, AlertDialogService>()
				.AddSingleton<INavigationService, NavigationService>()
				.AddTransient<Demo3ViewModel>()
				.AddTransient<Demo3>();

		return builder.Build();
	}
}
