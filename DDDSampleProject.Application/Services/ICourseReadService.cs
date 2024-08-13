using DDDSampleProject.Application.Models.CourseManagement;

namespace DDDSampleProject.Application.Services;

public interface ICourseReadService
{
    Task<bool> IsCourseExistByName(string courseName);
    Task<CourseReadModel> GetCourseReadById(Guid courseId);
    Task<IEnumerable<CourseReadModel>> SearchCourses(string searchPhrase);

}