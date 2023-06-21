using ControleDeEstoqueAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleDeEstoqueAPI.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Codigo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Descrição).HasMaxLength(1000);
            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.ValorCompra).IsRequired();
            builder.Property(x => x.ValorVenda).IsRequired();
        }
    }
}
