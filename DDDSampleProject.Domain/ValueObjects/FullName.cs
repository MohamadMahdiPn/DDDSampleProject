using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using DDDSampleProject.Domain.Exceptions.UserManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record FullName
{
    #region Constructor
    public FullName(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new FullNameNullOrEmptyException();
        if (value.Length > 50)
            throw new InvalidFullNameLengthException();
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(FullName value) => value.Value;
    public static implicit operator FullName(string value) => new FullName(value);
}
