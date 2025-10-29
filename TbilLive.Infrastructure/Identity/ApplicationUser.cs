using Microsoft.AspNetCore.Identity;
using TbilLive.Domain.Entities;

namespace TbilLive.Infrastructure.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
