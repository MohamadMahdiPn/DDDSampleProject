using DDDSampleProject.Application.Services;
using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Entities.UserManagement;

namespace DDDSampleProject.Infrastructure.Services;

public class EmailService : IEmailService
{
    #region Constructor

    #endregion


    public Task SendNewCourseAdevertise(Course course)
    {
        return Task.CompletedTask;
    }

    public Task SendWelcomeEmailToUser(User user)
    {
        return Task.CompletedTask;
    }
}
