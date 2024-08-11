using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.CourseManagement;

public class GetCoursesList:IQuery<IEnumerable<CourseDto>>
{

}