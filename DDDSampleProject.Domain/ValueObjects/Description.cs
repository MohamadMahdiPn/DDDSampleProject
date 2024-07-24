using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record Description
{
    #region Constructor
    public Description(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new DescriptionNullOrEmptyException();
        if (value.Length > 250)
            throw new InvalidDescriptionLengthException(250);
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(Description title) => title.Value;
    public static implicit operator Description(string value) => new Description(value);
}
