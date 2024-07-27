using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Domain.Entities.CourseManagement;

namespace DDDSampleProject.Domain.Events;

public record CourseAttendeeAddedEvent(Course course , CourseAttendee attendee):IDomainEvent;

