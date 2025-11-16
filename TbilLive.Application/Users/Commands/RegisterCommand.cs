using MediatR;

namespace TbilLive.Application.Users.Commands;

public class RegisterUserCommand(RegisterDto dto) : IRequest<Guid>
{
    public string UserName { get; init; } = dto.UserName;
    public string Email { get; init; } = dto.Email;
    public string Password { get; init; } = dto.Password;
}
