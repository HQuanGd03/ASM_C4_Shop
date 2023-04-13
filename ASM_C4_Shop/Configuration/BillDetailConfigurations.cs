using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.Configuration
{
    public class BillDetailConfigurations : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.HasKey(P=>P.Id);
            builder.Property(p=>p.Quantity).IsRequired().HasColumnType("int");
            builder.HasOne(p=>p.Bill).WithMany(p=>p.BillDetails).HasForeignKey(p=>p.IdHD);
            builder.HasOne(p => p.Product).WithMany(p => p.BillDetails).HasForeignKey(p => p.IdSP);
        }
    }
}
