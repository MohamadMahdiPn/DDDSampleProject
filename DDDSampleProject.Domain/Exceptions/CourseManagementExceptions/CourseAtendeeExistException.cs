using DDDSampleProject.Abstraction.Exceptions;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class CourseAtendeeExistException : CourseManagementException
{
    public CourseAtendeeExistException(BaseId id) : base($"Attendee {id} is Exists !!!")
    {

    }
}

