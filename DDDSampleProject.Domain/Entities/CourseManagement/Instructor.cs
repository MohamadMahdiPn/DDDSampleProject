using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class Instructor : BaseEntity
{
    #region Constructor

    public Instructor(BaseId id) : base(id)
    {

    }

    internal Instructor(BaseId id, FullName fullName, Biography biography) : base(id)
    {
        _fullName = fullName;
        _biography = biography;
        _experience = 3;
        _rating = 0;

    }
    internal Instructor(BaseId id, FullName fullName, Biography biography,int experience) : base(id)
    {
        _fullName = fullName;
        _biography = biography;
        _experience = experience;
        _rating = 0;

    }

    internal Instructor(BaseId id, FullName fullName, Biography biography, int experience, double rating) : base(id)
    {
        _fullName = fullName;
        _biography = biography;
        _experience = experience;
        _rating = rating;

    }
    #endregion


    private FullName _fullName;
    private Biography _biography;
    private LinkedList<Course> _courses;

    private int _experience;
    private double _rating;

    public void UpdateFullName(FullName  fullName)
    {
        _fullName = fullName;
    }
}