using DDDSampleProject.Application.Services;
using DDDSampleProject.Infrastructure.Ef;
using DDDSampleProject.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDDSampleProject.Infrastructure;

public static class Extensions
{
    public static IServiceCollection ConfigureInfraServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEFConfigurations(configuration);
        services.AddSingleton<IEmailService, EmailService>();

        return services;
    }
}
