// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Application.Contracts;
using FizzBuzzApp.App;
using Infrastructure.Services;

static void ConfigureServices(IServiceCollection services)
{

    // add services:
    services.AddSingleton<IApp, App>();
    services.AddSingleton<IServiceCreator<IFBService>, ServiceCreator<IFBService>>();

}


var services = new ServiceCollection();
ConfigureServices(services);

// create service provider
using var serviceProvider = services.BuildServiceProvider();

try
{
    serviceProvider.GetService<IApp>().Run(args);
}
catch (Exception)
{
    throw;
}