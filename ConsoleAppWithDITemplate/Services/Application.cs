using ConsoleAppWithDITemplate.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppWithDITemplate.Services;

public class Application : IApplication
{
    private readonly IConfigurationRoot _configuration;

    public Application(IConfigurationRoot configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

        // Add your custom code here
    }

    public void Run()
    {
        // Add your custom code here

        Console.WriteLine("Application is running...");
        Console.WriteLine();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
