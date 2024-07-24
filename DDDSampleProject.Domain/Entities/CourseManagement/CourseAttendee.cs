using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class CourseAttendee : BaseEntity
{
    #region Constructor

    public CourseAttendee(BaseId id) : base(id)
    {
    }

    internal CourseAttendee(BaseId id, BaseId courseId, BaseId userId) : base(id)
    {
        _courseId = courseId;
        _userId = userId;
    }

    #endregion


    private BaseId _courseId;
    private BaseId _userId;



}
