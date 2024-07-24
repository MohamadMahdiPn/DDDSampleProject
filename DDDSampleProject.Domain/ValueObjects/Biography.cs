using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record Biography
{
    #region Constructor
    public Biography(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new BiographyNullOrEmptyException();
        if (value.Length > 300)
            throw new InvalidBiographyLengthException();
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(Biography value) => value.Value;
    public static implicit operator Biography(string value) => new Biography(value);
}

