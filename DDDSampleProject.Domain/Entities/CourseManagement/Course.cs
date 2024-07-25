using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class Course : AggregateRoot<BaseId>
{
    #region Constructor
    internal Course(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId)
    {
        Id = id;
        _title = title;
        _description = description;
        _isFree = isFree;
        _price = price;
        _instructorId = instructorId;
    }


    public Course()
    {

    }


    #endregion


    private Title _title;
    private Description _description;
    private bool _isFree;
    private Price _price;
    private BaseId _instructorId;
    private LinkedList<CourseAttendee> _courseAttendees;
    private LinkedList<CourseCatalog> _courseCatalogs;

    #region Functions
    public void AddCourseAttendee(CourseAttendee courseAttendee)
    {
        if (_courseAttendees.Any(x => x.Id == courseAttendee.Id))
        {
            throw new CourseAtendeeExistException(courseAttendee.Id);
        }
        _courseAttendees.AddLast(courseAttendee);
    }

    private CourseAttendee GetAttendee(BaseId id)
    {
        var attendee = _courseAttendees.FirstOrDefault(x => x.Id == id);
        if (attendee is null)
            throw new CourseAttendeeNotFoundException(id);
        return attendee;
    }

    public void RemoveCourseAttendee(BaseId id)
    {
        var attendee = GetAttendee(id);
        _courseAttendees.Remove(attendee);
    }

    public void AddCourseCatalog(CourseCatalog courseCatalog)
    {
        if (_courseAttendees.Any(x => x.Id == courseCatalog.Id))
        {
            throw new CourseCatalogExistException(courseCatalog.Id);
        }
        _courseCatalogs.AddLast(courseCatalog);
    }

    private CourseCatalog GetCourseCatalog(BaseId id)
    {
        var attendee = _courseCatalogs.FirstOrDefault(x => x.Id == id);
        if (attendee is null)
            throw new CourseCatalogNotFoundException(id);
        return attendee;
    }

    public void RemoveCourseCatalog(BaseId id)
    {
        var attendee = GetCourseCatalog(id);
        _courseCatalogs.Remove(attendee);
    }
    #endregion
}
