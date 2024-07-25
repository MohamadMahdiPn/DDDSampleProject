using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class VideoUrlNullOrEmptyException : CourseManagementException
{
    public VideoUrlNullOrEmptyException() : base("Video Url can not be null !!!")
    {

    }
}

