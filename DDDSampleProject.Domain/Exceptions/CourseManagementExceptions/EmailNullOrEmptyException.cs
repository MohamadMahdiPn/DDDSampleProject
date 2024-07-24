using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class EmailNullOrEmptyException : CourseManagementException
{
    public EmailNullOrEmptyException() : base("Email can not be empty !!!")
    {

    }
}

