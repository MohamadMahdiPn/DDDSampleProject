using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Application.Exceptions;

public class CourseNotFoundException:CourseManagementException
{
    public CourseNotFoundException() : base("Course not found !!!")
    {
    }
}
