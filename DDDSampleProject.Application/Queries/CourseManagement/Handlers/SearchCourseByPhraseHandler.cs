using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Services;

namespace DDDSampleProject.Application.Queries.CourseManagement.Handlers;

public class SearchCourseByPhraseHandler:IQueryHandler<SearchCourseByPhrase,IEnumerable<CourseDto>>
{
    #region Constructor
    private readonly ICourseReadService _courseReadService;
    public SearchCourseByPhraseHandler(ICourseReadService courseReadService)
    {
        _courseReadService = courseReadService;
    }
    #endregion
    public async Task<IEnumerable<CourseDto>> HandleAsync(SearchCourseByPhrase query)
    {
        return (await _courseReadService.SearchCourses(query.SearchPhrase)).Select(c => c.ToDto()).ToList();
    }
}