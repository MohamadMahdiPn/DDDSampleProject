using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using DDDSampleProject.Domain.Exceptions.PaymentManagementExceptions;

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
    public static implicit operator Price(decimal value) => new Price(value);
}
public record Amount
{

    #region Constructor
    public Amount(decimal value)
    {

        if (value < 0)
            throw new InvalidAmountException();
        Value = value;
    }
    #endregion
    public decimal Value { get; set; }


    public static implicit operator decimal(Amount title) => title.Value;
    public static implicit operator Amount(string value) => new Amount(value);
}