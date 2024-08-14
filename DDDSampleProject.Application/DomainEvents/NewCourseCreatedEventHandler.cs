using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Application.Services;
using DDDSampleProject.Domain.Events;

namespace DDDSampleProject.Application.DomainEvents;

public class NewCourseCreatedEventHandler : IDomainEventHandler<NewCourseCreatedEvent>
{
    #region Constructor

    private readonly IEmailService _emailService;

    public NewCourseCreatedEventHandler(IEmailService emailService)
    {
        _emailService = emailService;
    }


    #endregion

    public async Task HandleAsync(NewCourseCreatedEvent @event)
    {
        await _emailService.SendNewCourseAdevertise(@event.course);
    }
}
