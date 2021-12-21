using Application.Services.TodoLists;
using Autofac;
using Autofac.Extras.DynamicProxy;
using CSB.Core.Infrastructure;
using CSB.Core.Infrastructure.Extensions;
using CSB.Core.Infrastructure.Specifications;
using System.Reflection;

namespace Infrastructure.Installers;

internal class DomainModuleInstaller : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        RegisterInterceptors(builder);
        RegisterApplicationServices(builder);
    }

    private void RegisterInterceptors(ContainerBuilder builder)
    {
        builder.RegisterInterceptors(Assembly);
    }
    private void RegisterApplicationServices(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(ApplicationAssembly)
                .Where(ApplicationServiceTypesSpecification.Create().ToExpression().Compile())
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors()
                .InstancePerDependency()
                .AddInterceptors(ApplicationAssembly)
                .AddInterceptors(CoreBootstrapper.Assembly);
    }

    private Assembly ApplicationAssembly { get; } = typeof(ITodoListService).Assembly;
    private Assembly Assembly { get; } = typeof(DomainModuleInstaller).Assembly;

}
