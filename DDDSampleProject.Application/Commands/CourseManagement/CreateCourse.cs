using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.CourseManagement;

public record CreateCourse(Guid id, string title, string description, bool isFree, decimal price, Guid instructorId) :ICommand;