using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface ICourseCatalog
{
    CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
}