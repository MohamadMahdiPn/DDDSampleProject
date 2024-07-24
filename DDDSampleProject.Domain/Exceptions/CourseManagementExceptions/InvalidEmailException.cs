using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidEmailException : CourseManagementException
{
    public InvalidEmailException() : base("Email is not correct !!!")
    {

    }
}

