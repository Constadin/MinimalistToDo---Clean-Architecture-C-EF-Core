using Microsoft.Extensions.DependencyInjection;
using MinimalistToDoList.Infrastructure.ServiceCollectionExtensions;
using MinimalistToDoList.Ui.appConfig;

namespace MinimalistToDoList.Ui.ServiceCollectionExtensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            {
                // Register Services
                

                //Register Classes
                services.AddSingleton<AppStartUp>();

                return services;
            }
        }
    }
}
