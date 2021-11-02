﻿// <auto-generated />
using ApiWeb_Produto_Estoque_CeA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiWeb_Produto_Estoque_CeA.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    [Migration("20211102180458_versao02")]
    partial class versao02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("ApiWeb_Produto_Estoque_CeA.Models.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("fornecedor")
                        .HasColumnType("longtext");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("local")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<string>("setor")
                        .HasColumnType("longtext");

                    b.Property<string>("tipo")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("ProdutoItems");
                });

            modelBuilder.Entity("ApiWeb_Produto_Estoque_CeA.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
