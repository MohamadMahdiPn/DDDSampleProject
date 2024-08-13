using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.UserManagement;

public class GetUserById : IQuery<UserDto>
{
    public Guid Id { get; set; }
}