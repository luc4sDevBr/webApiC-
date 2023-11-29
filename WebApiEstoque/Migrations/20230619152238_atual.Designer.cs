﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiEstoque.Data;

#nullable disable

namespace WebApiEstoque.Migrations
{
    [DbContext(typeof(SistemaApiEstoqueDbContext))]
    [Migration("20230619152238_atual")]
    partial class atual
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiEstoque.Models.funcionarioModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("funcao")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("idade")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("funcionario");
                });

            modelBuilder.Entity("WebApiEstoque.Models.produtosModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("quantidade")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("valor")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}