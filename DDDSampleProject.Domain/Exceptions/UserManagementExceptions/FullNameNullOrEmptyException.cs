using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class FullNameNullOrEmptyException : UserManagementException
{
    public FullNameNullOrEmptyException() : base("FullName can not be null")
    {

    }
}

