namespace DDDSampleProject.Application.Services;

public interface ICourseReadService
{
    Task<bool> IsCourseExistByName(string courseName);
}