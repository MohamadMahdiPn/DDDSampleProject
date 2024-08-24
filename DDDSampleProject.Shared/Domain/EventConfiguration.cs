using DDDSampleProject.Abstraction.Domain;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DDDSampleProject.Shared.Domain;

public static class EventConfiguration
{
    public static IServiceCollection AddEvents(this IServiceCollection services)
    {

        var assembly = Assembly.GetCallingAssembly();
        services.AddSingleton<IDomainEventDispacher, DomainEventDispacher>();

        services.Scan(s => s.FromAssemblies(assembly)
                .AddClasses(c => c.AssignableTo(typeof(IDomainEventHandler<>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());




        return services;
    }
}
