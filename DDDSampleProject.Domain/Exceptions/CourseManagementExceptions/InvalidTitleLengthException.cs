using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidTitleLengthException : CourseManagementException
{
    public InvalidTitleLengthException() : base("biography can not be more than 50")
    {

    }
}