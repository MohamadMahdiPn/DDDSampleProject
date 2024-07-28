using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidInstructorRatingException : CourseManagementException
{
    public InvalidInstructorRatingException() : base("raring can not be less than 0 !!!")
    {

    }
}
