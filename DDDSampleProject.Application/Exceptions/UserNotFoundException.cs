using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Application.Exceptions;

public class UserNotFoundException:UserManagementException
{
    public UserNotFoundException() : base("User not found !!!")
    {
    }
}