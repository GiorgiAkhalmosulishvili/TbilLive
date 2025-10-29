using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TbilLive.Domain.Entities;

namespace TbilLive.Infrastructure.Database.Configurations;

public class LikeConfiguration : IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.HasIndex(l => new { l.PostId, l.UserId }).IsUnique();

        builder.Property(l => l.CreatedAt)
            .HasDefaultValueSql("NOW()");
    }
}