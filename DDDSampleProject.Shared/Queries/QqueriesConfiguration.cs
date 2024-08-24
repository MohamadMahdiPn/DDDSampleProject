using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Shared.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DDDSampleProject.Shared.Queries;

public static class QqueriesConfiguration
{
    public static IServiceCollection AddQueries(this IServiceCollection services)
    {

        var assembly = Assembly.GetCallingAssembly();
        services.AddSingleton<IQueryDispacher, QueryDispacher>();

        services.Scan(s => s.FromAssemblies(assembly)
                .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());




        return services;
    }
}
