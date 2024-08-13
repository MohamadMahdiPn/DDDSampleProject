using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Models.CourseManagement;
using DDDSampleProject.Application.Models.UserManagement;

namespace DDDSampleProject.Application.Queries;

internal static class DtoMappers
{
    public static UserDto ToDto(this UserReadModel user)
    {
        return new UserDto
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            IsConfirmed = user.IsConfirmed,
            Password = user.Password

        };
    }

    public static CourseDto ToDto(this CourseReadModel course)
    {
        return new CourseDto
        {
            Id = course.Id,
            Description = course.Description,
            InstructorId = course.InstructorId,
            IsFree = course.IsFree,
            Price = course.Price,
            Title = course.Title
        };
    }

}

