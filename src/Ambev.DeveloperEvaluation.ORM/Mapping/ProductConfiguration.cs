using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.Name).IsRequired();
        builder.Property(u => u.Price).IsRequired().HasColumnType("decimal(18,2)");

        // Relacionamento com SaleItems (1:N)
        builder.HasMany(p => p.SaleItems)
               .WithOne(si => si.Product)
               .HasForeignKey(si => si.ProductId);

    }
}
