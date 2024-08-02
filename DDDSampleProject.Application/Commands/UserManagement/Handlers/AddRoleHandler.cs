using DDDSampleProject.Abstraction.Commands;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class AddRoleHandler : ICommandHandler<CreateRole>
{
    public Task HandlerAsync(CreateRole command)
    {
        throw new NotImplementedException();
    }
}