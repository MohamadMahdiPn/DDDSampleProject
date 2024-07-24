using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidDescriptionLengthException : CourseManagementException
{
    public InvalidDescriptionLengthException(int validLength) : base($"biography can not be more than {validLength}")
    {

    }
}
