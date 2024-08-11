using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.CourseManagement;

public class SearchCourseByPhrase:IQuery<IEnumerable<CourseDto>>
{

}