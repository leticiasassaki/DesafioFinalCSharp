using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlueBank.System.Domain.OrderManagement.Entities;
namespace BlueBank.System.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {

        /*public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("TB_CUSTOMER");

            builder
                .Property(x => x.CreatedAt)
                .HasColumnName("DT_CREATED")
                .IsRequired();

        }*/
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            throw new global::System.NotImplementedException();
        }
    }
}
