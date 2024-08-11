using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.UserManagement.Handlers;

public class GetUsersListHandler:IQueryHandler<GetUsersList,IEnumerable<UserDto>>
{
    public Task<IEnumerable<UserDto>> HandleAsync(GetUsersList query)
    {
        throw new NotImplementedException();
    }
}