using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.UserManagement;

public record UpdateRole(BaseId id, FullName fullName) : ICommand;