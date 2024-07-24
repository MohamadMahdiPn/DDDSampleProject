using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using System.Net.Mail;

namespace DDDSampleProject.Domain.ValueObjects;

public record Email
{
    #region Constructor
    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new EmailNullOrEmptyException();
       var emailAddress = new MailAddress(value);
        if (emailAddress.Address != value)
            throw new InvalidEmailException();
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(Email value) => value.Value;
    public static implicit operator Email(string value) => new Email(value);
}
