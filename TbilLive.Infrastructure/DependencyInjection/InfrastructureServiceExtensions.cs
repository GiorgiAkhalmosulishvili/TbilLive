using Microsoft.Extensions.DependencyInjection;
using TbilLive.Application.Users.Interfaces;
using TbilLive.Infrastructure.Services;

namespace TbilLive.Infrastructure.DependencyInjection;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();


        return services;
    }
}