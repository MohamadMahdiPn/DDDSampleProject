using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.CourseManagement.Handlers;

public class GetCoursesListHandler:IQueryHandler<GetCoursesList,IEnumerable<CourseDto>>
{
    public Task<IEnumerable<CourseDto>> HandleAsync(GetCoursesList query)
    {
        throw new NotImplementedException();
    }
}