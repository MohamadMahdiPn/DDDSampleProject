using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidDescriptionLengthException : CourseManagementException
{
    public InvalidDescriptionLengthException(int validLength) : base($"Description can not be more than {validLength}")
    {

    }
}
