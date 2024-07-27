using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface ICourseAttendee
{
    CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId);
}
