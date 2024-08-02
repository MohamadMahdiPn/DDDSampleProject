using DDDSampleProject.Abstraction.Commands;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class DeleteRoleHandler : ICommandHandler<DeleteRole>
{
    public Task HandlerAsync(DeleteRole command)
    {
        throw new NotImplementedException();
    }
}