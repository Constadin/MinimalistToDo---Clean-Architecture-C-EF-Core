﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MinimalistToDoList.Core.Interfaces;
using MinimalistToDoList.Infrastructure.Data;
using MinimalistToDoList.Infrastructure.Repositories;

namespace MinimalistToDoList.Infrastructure.ServiceCollectionExtensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {   
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("TodoDb");

            });

            services.AddScoped<ITodoRepository, TodoRepository>();
            return services;
        }
    }
}
