using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.UserManagement;


public record CreateUser(BaseId id, UserName userName, Password password, Email email, bool isConfirmed) : ICommand;