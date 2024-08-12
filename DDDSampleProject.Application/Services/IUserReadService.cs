namespace DDDSampleProject.Application.Services;

public interface IUserReadService
{
    Task<bool> IsUserExistByEmail(string email);
}
