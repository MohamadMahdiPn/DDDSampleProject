using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class Instructor:BaseEntity
{
    #region Constructor

    public Instructor(BaseId id):base(id)
    {
        
    }

    internal Instructor(BaseId id, FullName fullName, Biography biography) : base(id)
    {
        _fullName = fullName;
        _biography = biography;
      
    }

    #endregion
   private FullName _fullName;
   private Biography _biography;
   private LinkedList<Course> _courses;
  
}