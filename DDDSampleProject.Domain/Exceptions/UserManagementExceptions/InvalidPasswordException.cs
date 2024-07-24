using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class InvalidPasswordException : UserManagementException
{
    public InvalidPasswordException() : base("Password is not correct !!!")
    {

    }
}

