using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Entitites.CourseManagement;

public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsFree { get; set; }
    public decimal Price { get; set; }
    public Guid InstructorId { get; set; }
    public Instructor Instructor { get; set; }
    public List<CourseAttendee> CourseAttendees { get; set; }
    public List<CourseCatalog> CourseACatalogs { get; set; }
}
