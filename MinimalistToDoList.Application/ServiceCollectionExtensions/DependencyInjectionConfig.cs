using Microsoft.Extensions.DependencyInjection;
using MinimalistToDoList.Application.Intrefaces;
using MinimalistToDoList.Application.Services;

namespace MinimalistToDoList.Application.ServiceCollectionExtensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            {
                // Register Services
                services.AddScoped<ITodoService, TodoService>();
                

                //Register Classes


                return services;
            }
        }
    }
}
