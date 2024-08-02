using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.UserManagement;

public record DeleteUser(BaseId id) : ICommand;