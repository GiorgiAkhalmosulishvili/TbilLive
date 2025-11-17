using MediatR;
using Microsoft.AspNetCore.Mvc;
using TbilLive.Application.Users;
using TbilLive.Application.Users.Commands;

namespace TbilLive.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    {
        var command = new RegisterUserCommand(dto);
        var userId = await _mediator.Send(command);
        return Ok(new { UserId = userId });
    }
}