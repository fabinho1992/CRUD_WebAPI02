using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webAPI02.Models;

namespace webAPI02.Extenções
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            

            
            builder.HasOne(v => v.Cliente).WithMany(c => c.Vendas).HasForeignKey(c => c.ClienteId);

            
            builder.HasOne(v => v.Vendedor).WithMany(v =>v.Vendas).HasForeignKey(v => v.VendedorId);
        }
    }
}
