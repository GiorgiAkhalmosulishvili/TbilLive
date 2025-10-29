using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TbilLive.Domain.Entities;
using TbilLive.Infrastructure.Identity;

namespace TbilLive.Infrastructure.Database;

public class TbilLiveDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public TbilLiveDbContext(DbContextOptions<TbilLiveDbContext> options)
        : base(options) { }

    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Like> Likes => Set<Like>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(TbilLiveDbContext).Assembly);
    }
}