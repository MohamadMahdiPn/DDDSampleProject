namespace DDDSampleProject.Domain.Entitites.CourseManagement;

public class CourseAttendee
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public Guid UserId { get; set; }


}
