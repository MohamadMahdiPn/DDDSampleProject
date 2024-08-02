using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.Factories.UserManagement;
using DDDSampleProject.Domain.Repositories.UserManagement;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class AddUserHandler : ICommandHandler<CreateUser>
{
    #region Constructor

    private readonly IUserRepository _userRepository;
    private readonly IUserFactory _userFactory;

    public AddUserHandler(IUserRepository userRepository, IUserFactory userFactory)
    {
        _userRepository = userRepository;
        _userFactory = userFactory;
    }

    #endregion

    public async Task HandlerAsync(CreateUser command)
    {
        var user = _userFactory.Create(command.id, command.userName, command.password, command.email,
            command.isConfirmed);
        await _userRepository.AddAsync(user);
    }
}