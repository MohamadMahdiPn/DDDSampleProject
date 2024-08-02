using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.Factories.CourseManagement;
using DDDSampleProject.Domain.Repositories.CourseManagement;

namespace DDDSampleProject.Application.Commands.CourseManagement.Handlers;

public class CreateCourseHandler : ICommandHandler<CreateCourse>
{
    #region Constructor

    private readonly ICourseRepository _courseRepository;
    private readonly ICourseFactory _courseFactory;

    public CreateCourseHandler(ICourseRepository courseRepository, ICourseFactory courseFactory)
    {
        _courseRepository = courseRepository;
        _courseFactory = courseFactory;
    }

    #endregion


    public async Task HandlerAsync(CreateCourse command)
    {
        var course = _courseFactory.Create(command.id, command.title, command.description, command.isFree,
            command.price, command.instructorId);

        await _courseRepository.AddAsync(course);

    }
}