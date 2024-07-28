using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface ICourseAttendeeFactory
{
    CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId);
}


public class CourseAttendeeFactory : ICourseAttendeeFactory
{
    public CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId)
    {
        return new(id, courseId, userId);
    }
}