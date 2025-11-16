using MediatR;
using TbilLive.Application.Users.Interfaces;

namespace TbilLive.Application.Users.Commands;

public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Guid>
{
    private readonly IUserService _userService;

    public RegisterUserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        return await _userService.CreateUserAsync(request.UserName, request.Email, request.Password);
    }
}