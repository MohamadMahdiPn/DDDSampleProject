﻿using DDDSampleProject.Application.Models.UserManagement;
using DDDSampleProject.Application.Services;
using DDDSampleProject.Infrastructure.Ef.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Services;

public class UserReadService : IUserReadService
{
    #region Constructor
    private readonly ReadDbContext _context;
    public UserReadService(ReadDbContext context)
    {
        _context = context;
    }

   
    #endregion


    public async Task<bool> IsUserExistByEmail(string email)
    {
       return await _context.Users.AnyAsync(u => u.Email == email);
    }

    public async Task<UserReadModel> GetUserById(Guid id)
    {
        return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<IEnumerable<UserReadModel>> GetUsers()
    {
      return await _context.Users.AsNoTracking().ToListAsync();
    }
}
