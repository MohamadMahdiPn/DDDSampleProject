using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class DescriptionNullOrEmptyException : CourseManagementException
{
    public DescriptionNullOrEmptyException() : base("Description can not be null")
    {

    }
}
