using ConsoleAppWithDITemplate.Services;
using ConsoleAppWithDITemplate.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

var connectionString = configuration.GetConnectionString("MssqlConnectionSring") ?? throw new Exception("Connection string is required!");



IHost _host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
{
    services.AddSingleton<IConfigurationRoot>(configuration);


    // Todo: uncomment lines below to use Entity Framework Core
        //services.AddDbContext<AppDbContext>(options =>
        //    options.UseSqlServer(connectionString));
        //services.AddDbContext<AppDbContext>();

    services.AddSingleton<IApplication, Application>();

    // Register your services here
   
}).Build();


var app = _host.Services.GetRequiredService<IApplication>();
app.Run();