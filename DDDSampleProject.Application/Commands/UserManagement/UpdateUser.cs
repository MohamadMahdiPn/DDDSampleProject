using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.UserManagement;

public record UpdateUser(BaseId id, UserName userName, Password password, Email email, bool isConfirmed) :ICommand;