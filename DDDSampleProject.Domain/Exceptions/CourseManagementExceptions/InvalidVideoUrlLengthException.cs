using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidVideoUrlLengthException : CourseManagementException
{
    public InvalidVideoUrlLengthException() : base("biography can not be more than 300 !!!")
    {

    }
}

