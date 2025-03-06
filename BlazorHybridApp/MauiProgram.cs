using Microsoft.Extensions.Logging;

namespace BlazorHybridApp;

public static class MauiProgram
{
    //https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/4-blazor-components
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

		return builder.Build();
	}
}
