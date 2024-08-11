using DDDSampleProject.Infrastructure.Ef.Models.UserManagement;

namespace DDDSampleProject.Infrastructure.Ef.Models.CourseManagement;

public class CourseAttendeeReadModel
{
    public Guid UserId { get; set; }
    public UserReadModel User { get; set; }

    public Guid CourseId { get; set; }
    public CourseReadModel Course { get; set; }

}