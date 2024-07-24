using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidPasswordException : CourseManagementException
{
    public InvalidPasswordException() : base("Password is not correct !!!")
    {

    }
}

