using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Commands.CourseManagement;
using DDDSampleProject.Application.Commands.UserManagement;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Queries.CourseManagement;
using DDDSampleProject.Application.Queries.UserManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDDSampleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICommandDispacher _commandDispacher;
        private readonly IQueryDispacher _queryDispacher;

        public CourseController(IQueryDispacher queryDispacher, ICommandDispacher commandDispacher)
        {
            _queryDispacher = queryDispacher;
            _commandDispacher = commandDispacher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCoursesList()
        {
            var list = await _queryDispacher.FetchAsync(new GetCoursesList());
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateCourse command)
        {
            await _commandDispacher.DispachAsync(command);
            return Ok();
        }
    }
}
