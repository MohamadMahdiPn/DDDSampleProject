using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidVideoUrlLengthException : CourseManagementException
{
    public InvalidVideoUrlLengthException() : base("Video Url can not be more than 300 !!!")
    {

    }
}

