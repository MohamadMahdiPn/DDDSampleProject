using DDDSampleProject.Application.Services;
using DDDSampleProject.Infrastructure.Ef.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Services;

public class CourseReadService : ICourseReadService
{
    #region Constructor
    private readonly ReadDbContext _context;
    public CourseReadService(ReadDbContext context)
    {
        _context = context;
    }


    #endregion


    public async Task<bool> IsCourseExistByName(string courseName)
    {
       return await _context.Courses.AnyAsync(x=>x.Title.Contains(courseName));
    }
}
