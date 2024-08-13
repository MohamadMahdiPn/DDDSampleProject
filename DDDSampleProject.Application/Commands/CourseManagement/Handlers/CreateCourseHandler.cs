using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Application.Exceptions;
using DDDSampleProject.Application.Services;
using DDDSampleProject.Domain.Factories.CourseManagement;
using DDDSampleProject.Domain.Repositories.CourseManagement;

namespace DDDSampleProject.Application.Commands.CourseManagement.Handlers;

public class CreateCourseHandler : ICommandHandler<CreateCourse>
{
    #region Constructor

    private readonly ICourseRepository _courseRepository;
    private readonly ICourseFactory _courseFactory;
    private readonly ICourseReadService _courseReadService;
    public CreateCourseHandler(ICourseRepository courseRepository, ICourseFactory courseFactory, ICourseReadService courseReadService)
    {
        _courseRepository = courseRepository;
        _courseFactory = courseFactory;
        _courseReadService = courseReadService;
    }

    #endregion


    public async Task HandlerAsync(CreateCourse command)
    {
        if (await _courseReadService.IsCourseExistByName(command.title))
        {
            throw new CourseWithInputNameExistException();
        }


        var course = _courseFactory.Create(command.id, command.title, command.description, command.isFree,
            command.price, command.instructorId);

        await _courseRepository.AddAsync(course);

    }
}