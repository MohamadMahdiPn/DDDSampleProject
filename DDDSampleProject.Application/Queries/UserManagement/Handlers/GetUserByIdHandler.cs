using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.UserManagement.Handlers;

public class GetUserByIdHandler:IQueryHandler<GetUserById,UserDto>
{
    public Task<UserDto> HandleAsync(GetUserById query)
    {
        throw new NotImplementedException();
    }
}