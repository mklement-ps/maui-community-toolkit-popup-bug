using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiCommunityToolkit.ReproductionSample.PopupFillBug
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit(options =>
                {
                    options.SetPopupDefaults(new DefaultPopupSettings
                    {
                        Margin = 0,
                        Padding = 0
                    });
                    options.SetPopupOptionsDefaults(new DefaultPopupOptionsSettings
                    {
                        Shadow = null,
                        Shape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
                        {
                            CornerRadius = new CornerRadius(10, 10, 0, 0),
                            StrokeThickness = 0
                        }
                    });
                })
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
}
