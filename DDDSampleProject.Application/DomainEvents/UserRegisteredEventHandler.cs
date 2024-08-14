using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Application.Services;
using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Domain.Events;

namespace DDDSampleProject.Application.DomainEvents;

public class UserRegisteredEventHandler : IDomainEventHandler<UserRegisteredEvent>
{
    #region Constructor
    private readonly IEmailService _emailService;

    public UserRegisteredEventHandler(IEmailService emailService)
    {
        _emailService = emailService;
    }
    #endregion

    public async Task HandleAsync(UserRegisteredEvent @event)
    {
        await _emailService.SendWelcomeEmailToUser(@event.user);

    }
}
