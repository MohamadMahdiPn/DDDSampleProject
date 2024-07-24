namespace DDDSampleProject.Domain.Entitites.CourseManagement;

public class Lesson
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public Guid CourseId { get; set; }
    public Course Course { get; set; }

    public Guid CourseCatalogId { get; set; }
    public CourseCatalog CourseCatalog { get; set; }
}
