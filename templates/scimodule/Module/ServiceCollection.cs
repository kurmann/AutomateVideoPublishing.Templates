using Microsoft.Extensions.DependencyInjection;
using Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Services;
using Microsoft.Extensions.Configuration;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServiceCollectionIntegratedModule(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bindet Konfigurationswerte an ModuleSettings und registriert ModuleSettings als Options-Pattern
        services.Configure<ModuleSettings>(configuration.GetSection("ModuleSettings"));
        
        // Dienste hinzufügen
        services.AddHostedService<SampleHostedService>();
        
        return services;
    }
}
