using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.CourseManagement;

public record CreateCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) :ICommand;