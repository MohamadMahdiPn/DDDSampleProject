namespace DDDSampleProject.Infrastructure.Ef.Models.CourseManagement;

public class CourseCatalogReadModel : BaseReadModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid CourseCatalogId { get; set; }
    public CourseCatalogReadModel CourseCatalog { get; set; }
    public IReadOnlyList<LessonReadModel> Lessons { get; set; }
}