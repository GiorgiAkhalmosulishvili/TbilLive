using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TbilLive.Shared;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(
                Assembly.GetExecutingAssembly()
            );
        });

        return services;
    }
}
