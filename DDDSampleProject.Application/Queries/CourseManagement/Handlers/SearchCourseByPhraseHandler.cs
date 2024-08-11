using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.CourseManagement.Handlers;

public class SearchCourseByPhraseHandler:IQueryHandler<SearchCourseByPhrase,IEnumerable<CourseDto>>
{
    public Task<IEnumerable<CourseDto>> HandleAsync(SearchCourseByPhrase query)
    {
        throw new NotImplementedException();
    }
}