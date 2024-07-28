using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidInstructorExperienceException : CourseManagementException
{
    public InvalidInstructorExperienceException() : base("Instructor experience can not be less than 3  !!!")
    {

    }
}
