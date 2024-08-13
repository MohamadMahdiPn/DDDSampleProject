using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Services;

namespace DDDSampleProject.Application.Queries.CourseManagement.Handlers;

public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDto>
{

    #region Constructor
    private readonly ICourseReadService _courseReadService;
    public GetCourseByIdHandler(ICourseReadService courseReadService)
    {
        _courseReadService = courseReadService;
    }
    #endregion

    public async Task<CourseDto> HandleAsync(GetCourseById query)
    {
        return (await _courseReadService.GetCourseReadById(query.CourseId)).ToDto();
    }
}