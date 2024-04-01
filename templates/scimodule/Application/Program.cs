using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Application;

internal class Program
{
    static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                if (hostingContext.HostingEnvironment.IsDevelopment())
                {
                    config.AddUserSecrets<Program>();
                }
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddServiceCollectionIntegratedModule(hostContext.Configuration);
            });
    }
}
