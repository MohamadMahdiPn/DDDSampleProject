using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface IInstructorFactory
{
    Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography);
    Instructor CreateWithoutRating(BaseId id, FullName fullName, Biography biography, int experience);
    Instructor Create(BaseId id, FullName fullName, Biography biography, int experience, double rating);
}

public class InstructorFactory : IInstructorFactory
{
    public Instructor Create(BaseId id, FullName fullName, Biography biography, int experience, double rating)
    {
        if (experience < 3)
        {
            throw new InvalidInstructorExperienceException();
        }
        if (rating < 3)
        {
            throw new InvalidInstructorRatingException();
        }
        return new Instructor(id, fullName, biography, experience, rating);
    }

    public Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography)
    {
        return new Instructor(id, fullName, biography);
    }

    public Instructor CreateWithoutRating(BaseId id, FullName fullName, Biography biography, int experience)
    {
        if (experience <3)
        {
            throw new InvalidInstructorExperienceException();
        }
        return new Instructor(id, fullName, biography, experience);
    }
}