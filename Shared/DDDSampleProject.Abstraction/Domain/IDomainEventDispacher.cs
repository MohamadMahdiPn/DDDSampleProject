namespace DDDSampleProject.Abstraction.Domain;

public interface IDomainEventDispacher
{
    Task DispatchAsync <TEvent> (TEvent @event) where TEvent : class,IDomainEvent;
}
