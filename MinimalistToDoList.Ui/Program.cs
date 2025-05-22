// See https://aka.ms/new-console-template for more information


using Microsoft.Extensions.DependencyInjection;
using MinimalistToDoList.Application.ServiceCollectionExtensions;
using MinimalistToDoList.Infrastructure.Data;
using MinimalistToDoList.Infrastructure.ServiceCollectionExtensions;
using MinimalistToDoList.Ui.appConfig;
using MinimalistToDoList.Ui.ServiceCollectionExtensions;


// Configure Services
var serviceProvider = ConfigureServices();


using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    AppDbSeeder.Seed(context);  
}

var app = serviceProvider.GetRequiredService<AppStartUp>();

await app.RunAsync();


static ServiceProvider ConfigureServices()
{
    IServiceCollection services = new ServiceCollection();
    services.AddApplicationRegister();
    services.AddApplicationServices();
    services.AddInfrastructureServices();

    return services.BuildServiceProvider();
}

