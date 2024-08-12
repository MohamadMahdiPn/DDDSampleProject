using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Domain.Repositories.UserManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Infrastructure.Ef.Repositories;

public class UserRepository : IUserRepository
{
    public Task AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<User>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAsync(BaseId id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }
}

