using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiEstoque.Models;

namespace WebApiEstoque.Data.Map
{
    public class produtosMap : IEntityTypeConfiguration<produtosModel>
    {
        public void Configure(EntityTypeBuilder<produtosModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.descricao).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.quantidade).IsRequired().HasMaxLength(10);
            builder.Property(x => x.valor).IsRequired().HasMaxLength(40);
        }
    }
}
