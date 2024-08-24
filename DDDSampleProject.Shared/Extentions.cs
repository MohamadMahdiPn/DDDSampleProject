using DDDSampleProject.Shared.Commands;
using DDDSampleProject.Shared.Domain;
using DDDSampleProject.Shared.Exceptions;
using DDDSampleProject.Shared.Queries;
using DDDSampleProject.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDDSampleProject.Shared;

public static class Extentions
{
    public static IServiceCollection ConfigureSharedServices(this IServiceCollection services)
    {
        services.AddHostedService<AppInitializer>();
        services.AddCommands();
        services.AddQueries();
        services.AddEvents();
        services.AddScoped<ExceptionMiddleware>();

        return services;
    }
}
