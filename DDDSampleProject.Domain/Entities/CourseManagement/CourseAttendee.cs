namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class CourseAttendee
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public Guid UserId { get; set; }


}
