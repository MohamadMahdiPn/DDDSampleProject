using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Application.Exceptions;
using DDDSampleProject.Domain.Factories.UserManagement;
using DDDSampleProject.Domain.Repositories.UserManagement;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class UpdateUserHandler : ICommandHandler<UpdateUser>
{
    #region Constructor

    private readonly IUserRepository _userRepository;
    private readonly IUserFactory _userFactory;

    public UpdateUserHandler(IUserRepository userRepository, IUserFactory userFactory)
    {
        _userRepository = userRepository;
        _userFactory = userFactory;
    }

    #endregion
    public async Task HandlerAsync(UpdateUser command)
    {
        var user =await _userRepository.GetAsync(command.id);
        if (user == null)
            throw new UserNotFoundException();
        user = _userFactory.Create(command.id, command.userName, command.password, command.email,
            command.isConfirmed);
        await _userRepository.UpdateAsync(user);
    }
}