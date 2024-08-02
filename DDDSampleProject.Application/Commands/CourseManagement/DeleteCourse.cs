using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.CourseManagement;

public record DeleteCourse(BaseId id) : ICommand;