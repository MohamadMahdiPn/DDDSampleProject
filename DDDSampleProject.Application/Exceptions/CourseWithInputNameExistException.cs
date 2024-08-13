using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Application.Exceptions;

public class CourseWithInputNameExistException : CourseManagementException
{
    public CourseWithInputNameExistException() : base("Course with input Name exists !!!")
    {
    }
}
