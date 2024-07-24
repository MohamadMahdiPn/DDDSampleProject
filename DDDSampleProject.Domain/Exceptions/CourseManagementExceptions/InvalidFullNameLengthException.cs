using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidFullNameLengthException : CourseManagementException
{
    public InvalidFullNameLengthException() : base("biography can not be more than 50")
    {

    }
}

