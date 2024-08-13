using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Application.Exceptions;

public class UserWithEmailExistsException : CourseManagementException
{
    public UserWithEmailExistsException() : base("User with input Enmail exists !!!")
    {
    }
}