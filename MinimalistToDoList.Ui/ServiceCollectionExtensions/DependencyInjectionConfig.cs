﻿using Microsoft.Extensions.DependencyInjection;
using MinimalistToDoList.Application.Intrefaces;
using MinimalistToDoList.Application.Services;
using MinimalistToDoList.Ui.appConfig;

namespace MinimalistToDoList.Ui.ServiceCollectionExtensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddApplicationRegister(this IServiceCollection services)
        {
            {
                // Register Services
                services.AddSingleton<ITodoService, TodoService>();

                //Register Classes
                services.AddSingleton<AppStartUp>();

                return services;
            }
        }
    }
}
