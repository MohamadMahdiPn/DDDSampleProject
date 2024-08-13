using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Services;

namespace DDDSampleProject.Application.Queries.CourseManagement.Handlers;

public class GetCoursesListHandler:IQueryHandler<GetCoursesList,IEnumerable<CourseDto>>
{
    #region Constructor
    private readonly ICourseReadService _courseReadService;
    public GetCoursesListHandler(ICourseReadService courseReadService)
    {
        _courseReadService = courseReadService;
    }
    #endregion

    public Task<IEnumerable<CourseDto>> HandleAsync(GetCoursesList query)
    {
        throw new NotImplementedException();
    }
}