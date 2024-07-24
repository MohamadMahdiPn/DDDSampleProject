using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class VideoUrlNullOrEmptyException : CourseManagementException
{
    public VideoUrlNullOrEmptyException() : base("biography can not be null !!!")
    {

    }
}

