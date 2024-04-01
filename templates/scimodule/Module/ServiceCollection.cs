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
        // Bindet Root-Konfigurationswerte an ModuleSettings
        services.Configure<ModuleSettings>(configuration.GetSection(ModuleSettings.SectionName));
        
        // Dienste hinzufügen
        services.AddHostedService<SampleHostedService>();
        
        return services;
    }
}
