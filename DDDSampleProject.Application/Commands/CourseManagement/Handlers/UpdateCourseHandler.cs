using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Application.Exceptions;
using DDDSampleProject.Domain.Factories.CourseManagement;
using DDDSampleProject.Domain.Repositories.CourseManagement;

namespace DDDSampleProject.Application.Commands.CourseManagement.Handlers;

public class UpdateCourseHandler : ICommandHandler<UpdateCourse>
{
    #region Constructor

    private readonly ICourseRepository _courseRepository;
    private readonly ICourseFactory _courseFactory;

    public UpdateCourseHandler(ICourseRepository courseRepository, ICourseFactory courseFactory)
    {
        _courseRepository = courseRepository;
        _courseFactory = courseFactory;
    }

    #endregion

    public async Task HandlerAsync(UpdateCourse command)
    {
        var course = await _courseRepository.GetAsync(command.id);
        if (course == null)
            throw new CourseNotFoundException();
        course = _courseFactory.Create(command.id, command.title, command.description, command.isFree,
            command.price, command.instructorId);

        await _courseRepository.UpdateAsync(course);

    }

}