using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class CourseCatalog:BaseEntity
{
    #region Constructor

    internal CourseCatalog(BaseId id, Title title, Description description, BaseId courseId) 
        : base(id)
    {
        _title = title;
        _description = description;
        _courseId = courseId;

    }

    public CourseCatalog(BaseId id):base(id)
    {
        
    }
    #endregion
     
   

    private Title _title;
    private Description _description;
    private BaseId _courseId;
    private LinkedList<Lesson> _lessons;


}
