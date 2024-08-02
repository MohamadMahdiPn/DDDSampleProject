using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.UserManagement;

public record DeleteRole(BaseId id) : ICommand;