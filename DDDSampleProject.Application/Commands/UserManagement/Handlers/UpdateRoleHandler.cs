using DDDSampleProject.Abstraction.Commands;

namespace DDDSampleProject.Application.Commands.UserManagement.Handlers;

public class UpdateRoleHandler : ICommandHandler<UpdateRole>
{
    public Task HandlerAsync(UpdateRole command)
    {
        throw new NotImplementedException();
    }
}