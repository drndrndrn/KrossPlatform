using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
namespace Lab2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCompatibility()
                .ConfigureMauiHandlers((handlers) => {
#if ANDROID
handlers.AddHandler(typeof(MauiApp.Controls.BorderedEntry),typeof(MauiApp.Platforms.Android.Renderers.BorderedEntryRenderer));
#endif

                });

		return builder.Build();
	}
}
