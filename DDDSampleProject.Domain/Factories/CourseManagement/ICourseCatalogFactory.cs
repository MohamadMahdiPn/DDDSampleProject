using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface ICourseCatalogFactory
{
    CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
}


public class CourseCatalogFactory : ICourseCatalogFactory
{
    public CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId)
    {
       return new(id, title, description, courseId);
    }
}