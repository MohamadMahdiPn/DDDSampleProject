using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Application.Exceptions;
using DDDSampleProject.Application.Services;
using DDDSampleProject.Domain.Factories.UserManagement;
using DDDSampleProject.Domain.Repositories.UserManagement;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class AddUserHandler : ICommandHandler<CreateUser>
{
    #region Constructor

    private readonly IUserRepository _userRepository;
    private readonly IUserFactory _userFactory;
    private readonly IUserReadService _userReadService;
    public AddUserHandler(IUserRepository userRepository, IUserFactory userFactory, IUserReadService userReadService)
    {
        _userRepository = userRepository;
        _userFactory = userFactory;
        _userReadService = userReadService;
    }

    #endregion

    public async Task HandlerAsync(CreateUser command)
    {
        if (await _userReadService.IsUserExistByEmail(command.email))
        {
            throw new UserWithEmailExistsException();
        }


        var user = _userFactory.Create(command.id, command.userName, command.password, command.email,
            command.isConfirmed);
        await _userRepository.AddAsync(user);
    }
}