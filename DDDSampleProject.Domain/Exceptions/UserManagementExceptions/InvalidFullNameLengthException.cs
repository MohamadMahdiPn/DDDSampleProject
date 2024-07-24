using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class InvalidFullNameLengthException : UserManagementException
{
    public InvalidFullNameLengthException() : base("FullName can not be more than 50")
    {

    }
}

