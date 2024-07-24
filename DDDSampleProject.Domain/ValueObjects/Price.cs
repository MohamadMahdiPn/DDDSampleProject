using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record Price
{

    #region Constructor
    public Price(decimal value)
    {
       
        if (value< 0)
            throw new InvalidPriceException();
        Value = value;
    }
    #endregion
    public decimal Value { get; set; }


    public static implicit operator decimal(Price title) => title.Value;
    public static implicit operator Price(string value) => new Price(value);
}