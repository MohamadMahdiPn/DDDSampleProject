using DDDSampleProject.Application.Models.UserManagement;

namespace DDDSampleProject.Application.Services;

public interface IUserReadService
{
    Task<bool> IsUserExistByEmail(string email);
    Task<UserReadModel>GetUserById(Guid id);
    Task<IEnumerable<UserReadModel>> GetUsers();
}
