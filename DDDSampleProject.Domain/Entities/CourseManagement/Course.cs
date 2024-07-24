using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class Course : BaseEntity
{
    #region Constructor
    internal Course(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId)
        : base(id)
    {
        _title = title;
        _description = description;
        _isFree = isFree;
        _price = price;
        _instructorId = instructorId;
    }

    public Course(BaseId id) : base(id)
    {

    }


    #endregion


    private Title _title;
    private Description _description;
    private bool _isFree;
    private Price _price;
    private BaseId _instructorId;
    private LinkedList<CourseAttendee> _courseAttendees;
    private LinkedList<CourseCatalog> _courseCatalog;


}
