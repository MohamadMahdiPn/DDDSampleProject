using DDDSampleProject.Abstraction.Exceptions;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class CourseAttendeeNotFoundException : CourseManagementException
{
    public CourseAttendeeNotFoundException(BaseId id) : base($"Attendee {id} not found !!!")
    {

    }
}