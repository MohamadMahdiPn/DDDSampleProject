using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Factories.CourseManagement;

public interface ICourseFactory
{
    Course Create(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId);
}
