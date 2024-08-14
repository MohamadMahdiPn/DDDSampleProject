using DDDSampleProject.Abstraction.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace DDDSampleProject.Shared.Domain;

public class DomainEventDispacher : IDomainEventDispacher
{
    #region Construcrtor
    private readonly IServiceProvider _serviceProvider;
    public DomainEventDispacher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }


    #endregion

    async Task IDomainEventDispacher.DispatchAsync<TEvent>(TEvent @event)
    {
        using var scope = _serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<IDomainEventHandler<TEvent>>();

        await handler.HandleAsync(@event);
    }
}
