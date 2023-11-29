using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiEstoque.Models;

namespace WebApiEstoque.Data.Map
{
    public class funcionarioMap : IEntityTypeConfiguration<funcionarioModel>
    {
        public void Configure(EntityTypeBuilder<funcionarioModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.idade).IsRequired().HasMaxLength(3);
            builder.Property(x => x.funcao).IsRequired().HasMaxLength(2);
        }
    }
}
