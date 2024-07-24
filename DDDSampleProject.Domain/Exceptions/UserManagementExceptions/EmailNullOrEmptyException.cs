using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class EmailNullOrEmptyException : UserManagementException
{
    public EmailNullOrEmptyException() : base("Email can not be empty !!!")
    {

    }
}

