using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidVideoUrlExtentionException : CourseManagementException
{
    public InvalidVideoUrlExtentionException() : base("biography can be just mp4 !!!")
    {

    }
}

