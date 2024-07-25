using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

internal class RoleNameNullOrEmptyException : CourseManagementException
{
    public RoleNameNullOrEmptyException() : base("RoleName can not be empty !!!")
    {

    }
}

