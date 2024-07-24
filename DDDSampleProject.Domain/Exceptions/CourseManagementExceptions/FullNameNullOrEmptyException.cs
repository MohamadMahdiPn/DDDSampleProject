using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class FullNameNullOrEmptyException : CourseManagementException
{
    public FullNameNullOrEmptyException() : base("biography can not be null")
    {

    }
}

