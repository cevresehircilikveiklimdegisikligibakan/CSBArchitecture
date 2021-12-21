using Application;
using Application.Infrastructure.Persistence;
using CSB.Core;
using CSB.Core.Infrastructure;
using CSB.Core.Utilities;
using CSB.Core.Utilities.Caching.Redis;
using CSB.Core.Utilities.Logging;
using CSB.Core.Utilities.MessageBroking.RabbitMQ;
using CSB.Core.Utilities.Security.JWT;
using Domain;
using Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure;

public static class ServiceRegister
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddUtilityServices(configuration);
        services.AddApplicationDomainServices(configuration);
        services.AddServices(configuration);
        services.AddCoreInfrastructureServices(configuration);

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        SetAssembly();

        services.AddDbContext<ApplicationDbContext>();
        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

        return services;
    }
    private static IServiceCollection AddUtilityServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCoreServices(configuration);
        services.AddCoreUtilitiyServices(configuration);
        services.AddRedisCacheService(configuration);
        services.AddLogingService(configuration);
        services.AddRabbitMQMessageBrokingService(configuration);
        services.AddJwtSecurityService(configuration);
        return services;
    }
    private static IServiceCollection AddApplicationDomainServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDomainServices();
        services.AddApplicationServices(configuration);
        return services;
    }

    private static void SetAssembly()
    {
        Assemblies.Infrastructure = Assembly.GetExecutingAssembly();
    }
}
