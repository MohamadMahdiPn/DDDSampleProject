using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record RoleName
{
    #region Constructor
    public RoleName(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new RoleNameNullOrEmptyException();
      
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(RoleName value) => value.Value;
    public static implicit operator RoleName(string value) => new RoleName(value);
}
