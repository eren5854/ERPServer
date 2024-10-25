using ERPServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERPServer.Infrastructure.Configurations;
public sealed class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder
            .Property(p => p.FirstName)
            .IsRequired()
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);

        builder
            .Property(p => p.LastName)
            .IsRequired()
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);

        builder
            .Property(p => p.UserName)
            .IsRequired()
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);

        builder.HasQueryFilter(filter => !filter.IsDeleted);
    }
}
