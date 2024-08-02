using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Application.Exceptions;
using DDDSampleProject.Domain.Repositories.UserManagement;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class DeleteUserHandler : ICommandHandler<DeleteUser>
{
    #region Constructor

    private readonly IUserRepository _userRepository;

    public DeleteUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    #endregion

    public async Task HandlerAsync(DeleteUser command)
    {
        var user = await _userRepository.GetAsync(command.id);
        if (user == null)
            throw new UserNotFoundException();
        await _userRepository.DeleteAsync(user);
    }
}