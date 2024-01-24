using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webAPI02.Models;

namespace webAPI02.Extenções
{
    public class VendaItensCofiguration : IEntityTypeConfiguration<VendaItens>
    {
        public void Configure(EntityTypeBuilder<VendaItens> builder)
        {
            builder.HasOne(v => v.Produto).WithMany(p => p.VendaItens);
            builder.HasOne(v => v.Venda).WithMany(V => V.VendaItens);
        }
    }
}
