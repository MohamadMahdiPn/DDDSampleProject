using DDDSampleProject.Application.Models.CourseManagement;
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
       return await _context.Courses.AnyAsync(x=>x.Title ==courseName);
    }

    public async Task<IEnumerable<CourseReadModel>> SearchCourses(string searchPhrase)
    {
        return await _context.Courses.Where(c=>c.Title.Contains( searchPhrase)).ToListAsync();
    }
    public async Task<CourseReadModel> GetCourseReadById(Guid courseId)
    {
        return await _context.Courses.SingleOrDefaultAsync(x => x.Id == courseId);
    }

}
