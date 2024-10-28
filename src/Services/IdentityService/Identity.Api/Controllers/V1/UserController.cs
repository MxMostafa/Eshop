using Identity.Api.Controllers.BaseController;
using Identity.Application.Commands.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
  //  [ApiVersion]
    public class UserController : IBaseController
    {
        public readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("insert")]
        public async Task<IActionResult> InsertUser([FromBody] UserCommand userCommand)
        {
            var result = await _mediator.Send(userCommand);
            return Ok();
        }
    }
}
