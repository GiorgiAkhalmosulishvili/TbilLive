namespace TbilLive.Application.Users.Interfaces;

public interface IUserService
{
    Task<Guid> CreateUserAsync(string userName, string email, string password);
}
