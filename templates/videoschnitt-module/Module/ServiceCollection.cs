using Microsoft.Extensions.DependencyInjection;
using Kurmann.Videoschnitt.ModuleName.Services;
using Microsoft.Extensions.Configuration;

namespace Kurmann.Videoschnitt.ModuleName;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddModuleName(
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
