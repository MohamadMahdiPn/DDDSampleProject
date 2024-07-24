using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class UserNameNullOrEmptyException : CourseManagementException
{
    public UserNameNullOrEmptyException() : base("UserName can not be empty !!!")
    {

    }
}
