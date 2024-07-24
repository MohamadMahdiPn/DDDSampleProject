using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidBiographyLengthException : CourseManagementException
{
    public InvalidBiographyLengthException() : base("biography can not be more than 300")
    {

    }
}
