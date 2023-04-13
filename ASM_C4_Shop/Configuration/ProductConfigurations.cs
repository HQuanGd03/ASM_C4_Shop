using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.Configuration
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p =>  p.Id );
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Supplier).IsUnicode(true).IsFixedLength().HasMaxLength(100).HasColumnType("nvarchar");
            builder.HasOne(p => p.Brand).WithMany(p => p.Product).HasForeignKey(p => p.BrandId);
            builder.HasOne(p => p.Color).WithMany(p => p.Product).HasForeignKey(p => p.ColorId);
            builder.HasOne(p => p.Size).WithMany(p => p.Product).HasForeignKey(p => p.SizeId);
        }
    }
}
