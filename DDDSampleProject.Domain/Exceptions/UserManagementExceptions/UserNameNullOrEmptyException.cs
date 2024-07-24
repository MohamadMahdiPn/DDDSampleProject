using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class UserNameNullOrEmptyException : UserManagementException
{
    public UserNameNullOrEmptyException() : base("UserName can not be empty !!!")
    {

    }
}
