using DDDSampleProject.Abstraction.Exceptions;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class CourseCatalogNotFoundException : CourseManagementException
{
    public CourseCatalogNotFoundException(BaseId id) : base($"Course catalog {id} not found !!!")
    {

    }
}