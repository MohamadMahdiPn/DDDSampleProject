using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidPriceException : CourseManagementException
{
    public InvalidPriceException() : base("biography can not be less than 0 ")
    {

    }
}

