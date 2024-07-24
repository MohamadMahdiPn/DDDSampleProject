namespace DDDSampleProject.Domain.Entitites.CourseManagement;

public class CourseCatalog
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
    public List<Lesson> Lessons { get; set; }

}
