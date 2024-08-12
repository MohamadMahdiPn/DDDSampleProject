using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Repositories.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Infrastructure.Ef.Repositories;

public class CourseRepository : ICourseRepository
{
    public Task AddAsync(Course entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Course entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Course>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Course> GetAsync(BaseId id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Course entity)
    {
        throw new NotImplementedException();
    }
}

