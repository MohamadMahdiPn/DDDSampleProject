using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.UserManagement;


public record CreateUser(Guid id, string userName, string password, string email, bool isConfirmed) : ICommand;