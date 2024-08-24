using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Application.DomainEvents;
using DDDSampleProject.Domain.Events;
using DDDSampleProject.Domain.Factories.CourseManagement;
using DDDSampleProject.Domain.Factories.UserManagement;
using DDDSampleProject.Shared.Commands;
using DDDSampleProject.Shared.Domain;
using DDDSampleProject.Shared.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace DDDSampleProject.Application;

public static class Extentions
{
    public static IServiceCollection AddApplicationConfiguration(this IServiceCollection services)
    {
        services.AddSingleton<IUserFactory, UserFactory>();
        services.AddSingleton<ICourseFactory, CourseFactory>();
   
        
        services.AddScoped<IDomainEventHandler<NewCourseCreatedEvent>, NewCourseCreatedEventHandler>();
        services.AddScoped<IDomainEventHandler<UserRegisteredEvent>, UserRegisteredEventHandler>();

        services.AddEvents();
        services.AddCommands();
        services.AddQueries();

        return services;

    }
}
