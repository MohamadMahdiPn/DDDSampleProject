namespace DDDSampleProject.Domain.Entitites.CourseManagement;

public class Instructor
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    public List<Course> Courses { get; set; }
}