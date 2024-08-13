using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Services;

namespace DDDSampleProject.Application.Queries.UserManagement.Handlers;

public class GetUsersListHandler:IQueryHandler<GetUsersList,IEnumerable<UserDto>>
{
    #region Constructor
    private readonly IUserReadService _userReadService;
    public GetUsersListHandler(IUserReadService userReadService)
    {
        _userReadService = userReadService;
    }
    #endregion


    public async Task<IEnumerable<UserDto>> HandleAsync(GetUsersList query)
    {
        return (await _userReadService.GetUsers()).Select(c=>c.ToDto()).ToList();
    }
}