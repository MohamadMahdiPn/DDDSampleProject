using DDDSampleProject.Abstraction.Exceptions;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class CourseCatalogExistException : CourseManagementException
{
    public CourseCatalogExistException(BaseId id) : base($"Course catalog {id} is Exists !!!")
    {

    }
}

