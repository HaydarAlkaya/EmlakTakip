using EmlakTakipMAUI.Data;
using EmlakTakipMAUI.Data.IServices;
using Microsoft.Extensions.Logging;

namespace EmlakTakipMAUI
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ICategoryService, CategoryService>();
            builder.Services.AddSingleton<ICityService, CityService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddSingleton<INeighbourhoodService, NeighbourhoodService>();
            builder.Services.AddSingleton<IOwnerShipService, OwnerShipService>();
            builder.Services.AddSingleton<ITownService, TownService>();
            return builder.Build();
        }
    }
}
