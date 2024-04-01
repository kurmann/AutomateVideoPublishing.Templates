using Microsoft.Extensions.DependencyInjection;
using Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Services;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule;

public static class ServiceCollection
{
    public static IServiceCollection AddServiceCollectionIntegratedModule(this IServiceCollection services, ModuleSettings? moduleSettings)
    {
        if (moduleSettings != null)
        {
            services.AddSingleton(moduleSettings);

            services.AddHostedService<SampleHostedService>();
        }

        return services;
    }
}
