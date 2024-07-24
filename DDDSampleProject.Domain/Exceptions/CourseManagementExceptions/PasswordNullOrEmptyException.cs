using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class PasswordNullOrEmptyException : CourseManagementException
{
    public PasswordNullOrEmptyException() : base("Password can not be empty !!!")
    {

    }
}

