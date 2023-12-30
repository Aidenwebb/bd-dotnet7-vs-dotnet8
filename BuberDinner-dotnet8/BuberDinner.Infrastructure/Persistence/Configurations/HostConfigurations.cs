using BuberDinner.Domain.HostAggregate;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.UserAggregate.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuberDinner.Infrastructure.Persistence.Configurations;

public class HostConfigurations : IEntityTypeConfiguration<Host>
{
    public void Configure(EntityTypeBuilder<Host> builder)
    {
        ConfigureHostsTable(builder);
        ConfigureHostMenuIdsTable(builder);
        ConfigureHostDinnerIdsTable(builder);
    }

    private static void ConfigureHostMenuIdsTable(EntityTypeBuilder<Host> builder)
    {
        builder.OwnsMany(h => h.MenuIds, mib =>
        {
            mib.WithOwner().HasForeignKey("HostId");

            mib.ToTable("HostMenuIds");

            mib.HasKey("Id");

            mib.Property(mi => mi.Value)
                .ValueGeneratedNever()
                .HasColumnName("HostMenuId");
        });

        builder.Metadata.FindNavigation(nameof(Host.MenuIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private static void ConfigureHostDinnerIdsTable(EntityTypeBuilder<Host> builder)
    {
        builder.OwnsMany(h => h.DinnerIds, mib =>
        {
            mib.WithOwner().HasForeignKey("HostId");

            mib.ToTable("HostDinnerIds");

            mib.HasKey("Id");

            mib.Property(mi => mi.Value)
                .ValueGeneratedNever()
                .HasColumnName("HostDinnerId");
        });

        builder.Metadata.FindNavigation(nameof(Host.DinnerIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private static void ConfigureHostsTable(EntityTypeBuilder<Host> builder)
    {
        builder.HasKey(h => h.Id);

        builder.Property(h => h.Id)
            .HasConversion(
                id => id.Value,
                value => HostId.Create(value));

        builder.ToTable("Hosts");

        builder.Property(h => h.FirstName)
            .HasMaxLength(100);

        builder.Property(h => h.LastName)
            .HasMaxLength(100);

        builder.OwnsOne(h => h.AverageRating);

        builder.Property(h => h.UserId)
            .HasConversion(
                id => id.Value,
                value => UserId.Create(value));
    }
}