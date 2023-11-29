using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WebApiEstoque.Controllers;
using WebApiEstoque.Data.Map;
using WebApiEstoque.Models;

namespace WebApiEstoque.Data
{ //ORM faz toda a estrutura de entidade depois cria as taabelas atraves do Csharp
    public class SistemaApiEstoqueDbContext : DbContext
    {
        public SistemaApiEstoqueDbContext(DbContextOptions <SistemaApiEstoqueDbContext> options)
            :base(options) 
        {

        }

        //representa uma tabelaa: ao rodar o migration ele(entittyframework) vai criaar uma tabela funcionarios
        public DbSet<funcionarioModel> funcionario { get; set; }
        public DbSet<produtosModel> produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new funcionarioMap());
            modelBuilder.ApplyConfiguration(new produtosMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
