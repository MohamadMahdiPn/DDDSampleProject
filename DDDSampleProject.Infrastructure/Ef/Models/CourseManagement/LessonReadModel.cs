namespace DDDSampleProject.Infrastructure.Ef.Models.CourseManagement;

public class LessonReadModel
{
    public string Title { get; set; }
    public string VideoUrl { get; set; }
    public Guid CourseCatalogId { get; set; }
    public CourseCatalogReadModel CourseCatalog { get; set; }
}