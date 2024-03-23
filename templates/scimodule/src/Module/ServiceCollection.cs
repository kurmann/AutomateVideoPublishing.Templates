using Microsoft.Extensions.DependencyInjection;
using ServiceCollectionIntegratedModule.Module.Services;

namespace ServiceCollectionIntegratedModule.Module;

public static class ServiceCollection
{
    public static IServiceCollection AddModuleServices(this IServiceCollection services, ModuleSettings? moduleSettings)
    {
        if (moduleSettings != null)
        {
            services.AddSingleton(moduleSettings);

            services.AddHostedService<SampleHostedService>();
        }

        return services;
    }
}
