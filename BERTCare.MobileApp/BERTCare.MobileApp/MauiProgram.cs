using Microsoft.Extensions.Logging;
using UXDivers.Grial;

namespace BERTCare.MobileApp
{
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
                    fonts.AddFont("Poppins-Regular.ttf","Poppins");
                    fonts.AddFont("materialdesignicons-webfont.ttf","Material Design Icons");
                })

                .ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler<NavigationPage, UXDivers.Grial.GrialNavigationPageHandler>();
                    handlers.AddHandler<ScrollView, BERTCare.MobileApp.ScrollViewHandler>();
                    handlers.AddHandler<Label, BERTCare.MobileApp.LabelHandler>();
                    handlers.AddHandler<Entry, UXDivers.Grial.EntryHandler>();
                })
                .UseGrial();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
