using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.Configuration
{
    public class BillConfigurations : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p=>p.Status).IsRequired().HasColumnType("int");
            builder.HasOne(p => p.User).WithMany(p => p.Bill).HasForeignKey(p => p.UserId);
        }
    }
}
