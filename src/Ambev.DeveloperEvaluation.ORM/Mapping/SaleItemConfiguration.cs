using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItems");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.SaleId).IsRequired();
        builder.Property(u => u.ProductId).IsRequired();
        builder.Property(u => u.Quantity).IsRequired();
        builder.Property(u => u.Amount).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(u => u.Discount).IsRequired().HasColumnType("decimal(18,2)");

        // Relacionamento com Sale (N:1)
        builder.HasOne(si => si.Sale)
               .WithMany(s => s.SaleItems)
               .HasForeignKey(si => si.SaleId)
               .OnDelete(DeleteBehavior.Cascade);

        // Relacionamento com Product (N:1)
        builder.HasOne(si => si.Product)
               .WithMany(p => p.SaleItems)
               .HasForeignKey(si => si.ProductId)
               .OnDelete(DeleteBehavior.Restrict);

    }
}
