using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class PasswordNullOrEmptyException : UserManagementException
{
    public PasswordNullOrEmptyException() : base("Password can not be empty !!!")
    {

    }
}

