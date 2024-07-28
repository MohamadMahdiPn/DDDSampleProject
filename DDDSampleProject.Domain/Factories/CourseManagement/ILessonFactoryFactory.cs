using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface ILessonFactoryFactory
{
    Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId);
}
public class LessonFactoryFactory : ILessonFactoryFactory
{
    public Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId)
    {
        return new(id, title, videoUrl, courseCatalogId);
    }
}