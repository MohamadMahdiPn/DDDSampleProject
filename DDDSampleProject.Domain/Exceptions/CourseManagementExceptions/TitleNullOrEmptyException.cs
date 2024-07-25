using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class TitleNullOrEmptyException : CourseManagementException
{
    public TitleNullOrEmptyException() : base("Title can not be null")
    {

    }
}

