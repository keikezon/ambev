using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.UserId).IsRequired();
        builder.Property(u => u.Amount).IsRequired().HasColumnType("decimal(18,2)");

        builder.Property(u => u.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        // Relacionamento com User (Sale N:1 User)
        builder.HasOne(s => s.User)
               .WithMany(u => u.Sales)
               .HasForeignKey(s => s.UserId)
               .OnDelete(DeleteBehavior.Restrict);

        // Relacionamento Sale -> SaleItems (1:N)
        builder.HasMany(s => s.SaleItems)
               .WithOne(si => si.Sale)
               .HasForeignKey(si => si.SaleId)
               .OnDelete(DeleteBehavior.Cascade);

    }
}
