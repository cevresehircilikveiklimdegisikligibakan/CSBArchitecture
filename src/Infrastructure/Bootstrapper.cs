using Autofac;
using CSB.Core.Infrastructure;
using Infrastructure.Installers;

namespace Infrastructure;

public class Bootstrapper
{
    public static void Register(ContainerBuilder builder)
    {
        CoreBootstrapper.RegisterCoreBootstrapper(builder);
        RegisterInfrastructureBootstrapper(builder);
    }

    private static void RegisterInfrastructureBootstrapper(ContainerBuilder builder)
    {
        builder.RegisterModule(new DomainModuleInstaller());
    }
}
