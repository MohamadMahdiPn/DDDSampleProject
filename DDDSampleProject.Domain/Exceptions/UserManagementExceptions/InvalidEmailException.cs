using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class InvalidEmailException : UserManagementException
{
    public InvalidEmailException() : base("Email is not correct !!!")
    {

    }
}

