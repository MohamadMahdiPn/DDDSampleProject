using DDDSampleProject.Abstraction.Commands;

namespace DDDSampleProject.Abstraction.Commands;

public interface ICommandDispacher
{
    Task DispachAsync<TCommand>(TCommand command) where TCommand: class, ICommand;
}
