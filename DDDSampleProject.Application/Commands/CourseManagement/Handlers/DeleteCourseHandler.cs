using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Application.Exceptions;
using DDDSampleProject.Domain.Factories.CourseManagement;
using DDDSampleProject.Domain.Repositories.CourseManagement;

namespace DDDSampleProject.Application.Commands.CourseManagement.Handlers;

public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
{
    #region Constructor

    private readonly ICourseRepository _courseRepository;


    public DeleteCourseHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
     
    }

    #endregion
    public async Task HandlerAsync(DeleteCourse command)
    {
        var course = await _courseRepository.GetAsync(command.id);
        if (course == null)
            throw new CourseNotFoundException();
       
        await _courseRepository.DeleteAsync(course);

    }

}