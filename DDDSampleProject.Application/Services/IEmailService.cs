using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Entities.UserManagement;

namespace DDDSampleProject.Application.Services;

public interface IEmailService
{
    Task SendWelcomeEmailToUser(User user);
    Task SendNewCourseAdevertise(Course course);

}
