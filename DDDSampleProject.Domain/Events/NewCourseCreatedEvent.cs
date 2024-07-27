using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Domain.Entities.CourseManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Events;

public record NewCourseCreatedEvent(Course course):IDomainEvent;

