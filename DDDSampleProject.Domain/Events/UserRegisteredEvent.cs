using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Domain.Entities.UserManagement;

namespace DDDSampleProject.Domain.Events;

public record UserRegisteredEvent(User user):IDomainEvent;

