using CSB.Core;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Domain;

public static class ServiceRegister
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        SetAssembly();
        return services;
    }
        
    private static void SetAssembly()
    {
        Assemblies.Domain = Assembly.GetExecutingAssembly();
    }
}
