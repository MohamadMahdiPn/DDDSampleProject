using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record UserName
{
    #region Constructor
    public UserName(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new UserNameNullOrEmptyException();
       
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(UserName value) => value.Value;
    public static implicit operator UserName(string value) => new UserName(value);
}
