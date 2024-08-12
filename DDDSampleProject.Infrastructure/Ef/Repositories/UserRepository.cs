using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Domain.Repositories.UserManagement;
using DDDSampleProject.Domain.ValueObjects;
using DDDSampleProject.Infrastructure.Ef.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Repositories;

public class UserRepository : IUserRepository
{
    #region Constructor
    private readonly WriteDbContext _writeDbContext;
    public UserRepository(WriteDbContext writeDbContext)
    {
        _writeDbContext = writeDbContext;
    }
    #endregion


    #region Add
    public async Task AddAsync(User entity)
    {
        await _writeDbContext.AddAsync(entity);
        await _writeDbContext.SaveChangesAsync();
    }
    #endregion

    #region Delete
    public async Task DeleteAsync(User entity)
    {
        _writeDbContext.Users.Remove(entity);
        await _writeDbContext.SaveChangesAsync();
    }
    #endregion

    #region GetAll
    public async Task<IReadOnlyList<User>> GetAll()
    {
        return await _writeDbContext.Users.Include("_userRoles").ToListAsync();
    }
    #endregion

    #region Get
    public async Task<User> GetAsync(BaseId id)
    {
        return await _writeDbContext.Users.SingleAsync(x => x.Id == id);
    }
    #endregion

    #region Update
    public async Task UpdateAsync(User entity)
    {
        _writeDbContext.Users.Update(entity);
        await _writeDbContext.SaveChangesAsync();
    }
    #endregion


}

