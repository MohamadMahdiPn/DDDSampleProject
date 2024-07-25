using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidVideoUrlExtentionException : CourseManagementException
{
    public InvalidVideoUrlExtentionException() : base("Video Url can be just mp4 !!!")
    {

    }
}

