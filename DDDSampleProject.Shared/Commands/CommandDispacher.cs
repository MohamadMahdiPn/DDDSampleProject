using DDDSampleProject.Abstraction.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace DDDSampleProject.Shared.Commands;

internal sealed class CommandDispacher : ICommandDispacher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispacher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    async Task ICommandDispacher.DispachAsync<TCommand>(TCommand command)
    {
        using var scope = _serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();
        await handler.HandlerAsync(command);
    }
}
