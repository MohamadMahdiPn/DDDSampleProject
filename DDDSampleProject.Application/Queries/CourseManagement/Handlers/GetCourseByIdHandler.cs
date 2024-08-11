using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.CourseManagement.Handlers;

public class GetCourseByIdHandler:IQueryHandler<GetCourseById,CourseDto>
{
    public Task<CourseDto> HandleAsync(GetCourseById query)
    {
        throw new NotImplementedException();
    }
}