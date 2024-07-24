using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class TitleNullOrEmptyException : CourseManagementException
{
    public TitleNullOrEmptyException() : base("biography can not be null")
    {

    }
}

