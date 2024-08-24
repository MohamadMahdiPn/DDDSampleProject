using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Commands.UserManagement;
using DDDSampleProject.Application.Dtos;
using DDDSampleProject.Application.Queries.UserManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDDSampleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICommandDispacher _commandDispacher;
        private readonly IQueryDispacher _queryDispacher;

        public UsersController(IQueryDispacher queryDispacher, ICommandDispacher commandDispacher)
        {
            _queryDispacher = queryDispacher;
            _commandDispacher = commandDispacher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersList()
        {
            var list = await _queryDispacher.FetchAsync(new GetUsersList());
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser( [FromBody]CreateUser command)
        {
            await _commandDispacher.DispachAsync(command);
            return Ok();
        }
    }
}
