using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Repositories.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;
using DDDSampleProject.Infrastructure.Ef.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Repositories;

public class CourseRepository : ICourseRepository
{
    #region Constructor
    private readonly WriteDbContext _writeDbContext;
    public CourseRepository(WriteDbContext writeDbContext)
    {
        _writeDbContext = writeDbContext;
    }
    #endregion


    #region Add
    public async Task AddAsync(Course entity)
    {
        await _writeDbContext.AddAsync(entity);
        await _writeDbContext.SaveChangesAsync();
    }
    #endregion

    #region Delete
    public async Task DeleteAsync(Course entity)
    {
        _writeDbContext.Courses.Remove(entity);
        await _writeDbContext.SaveChangesAsync();
    }
    #endregion

    #region GetAll
    public async Task<IReadOnlyList<Course>> GetAll()
    {
        return await _writeDbContext.Courses.Include("_courseAttendees").ToListAsync();
    }
    #endregion

    #region Get
    public async Task<Course> GetAsync(BaseId id)
    {
        return await _writeDbContext.Courses.SingleAsync(x => x.Id == id);
    }
    #endregion

    #region Update
    public async Task UpdateAsync(Course entity)
    {
        _writeDbContext.Courses.Update(entity);
        await _writeDbContext.SaveChangesAsync();
    }
    #endregion

}

