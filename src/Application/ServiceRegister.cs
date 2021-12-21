using Application.Services.TodoItems;
using Application.Services.TodoLists;
using CSB.Core;
using CSB.Core.Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class ServiceRegister
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        SetAssembly();

        services.AddCoreApplicationServices(configuration);
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ITodoListService, TodoListService>();
        services.AddScoped<ITodoListInternalService, TodoListService>();
        services.AddScoped<ITodoItemService, TodoItemService>();
        services.AddScoped<ITodoItemInternalService, TodoItemService>();

        return services;
    }

    private static void SetAssembly()
    {
        Assemblies.Application = Assembly.GetExecutingAssembly();
    }
}
