using DDDSampleProject.Application.Services;
using DDDSampleProject.Domain.Repositories.CourseManagement;
using DDDSampleProject.Domain.Repositories.UserManagement;
using DDDSampleProject.Infrastructure.Ef.Context;
using DDDSampleProject.Infrastructure.Ef.Repositories;
using DDDSampleProject.Infrastructure.Ef.Services;
using DDDSampleProject.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDDSampleProject.Infrastructure.Ef;

public static class Extensions
{
    public static IServiceCollection AddEFConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<IUserReadService, UserReadService>();
        services.AddScoped<ICourseReadService, CourseReadService>();

        var options = configuration.GetOptions<Options.DbContextOptions>("DbContextConnectionString");

        services.AddDbContext<ReadDbContext>(ct => ct.UseSqlServer(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(ct => ct.UseSqlServer(options.ConnectionString));
        return services;

    }
}

