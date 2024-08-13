using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Services;

namespace DDDSampleProject.Application.Queries.UserManagement.Handlers;

public class GetUserByIdHandler:IQueryHandler<GetUserById,UserDto>
{
    #region Constructor
    private readonly IUserReadService _userReadService;
    public GetUserByIdHandler(IUserReadService userReadService)
    {
        _userReadService = userReadService;
    }
    #endregion


    public async Task<UserDto> HandleAsync(GetUserById query)
    {
        return (await _userReadService.GetUserById(query.Id)).ToDto();
    }
}