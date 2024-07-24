using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using System.Text.RegularExpressions;
using DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record Password
{
    #region Constructor
    public Password(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new PasswordNullOrEmptyException();
        string pattern = "{^a-zA-Z0-9}";
        var regex = new Regex(pattern);
        if (!regex.IsMatch(value))
            throw new InvalidPasswordException();
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(Password value) => value.Value;
    public static implicit operator Password(string value) => new Password(value);
}
