using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlueBank.System.Domain.OrderManagement.Entities;


public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    /*public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("TB_ACCOUNT");

        //mapeamete de relacionamento 1 para muitos
        builder
            //.HasOne(i => i.Id)
            //.WithMany(o => o.Items)
            //.HasForeignKey(i => i.CustomerId);
    }*/
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        throw new System.NotImplementedException();
    }
}

