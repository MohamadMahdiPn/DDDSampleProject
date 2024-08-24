using DDDSampleProject.Abstraction.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DDDSampleProject.Shared.Commands;

public static class CommandsConfiguration
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {

        var assembly = Assembly.GetCallingAssembly();
        services.AddSingleton<ICommandDispacher, CommandDispacher>();

        services.Scan(s => s.FromAssemblies(assembly)
                .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());




        return services;
    }
}
