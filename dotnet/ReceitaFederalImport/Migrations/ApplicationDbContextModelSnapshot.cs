﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceitaFederalImport.Data;

#nullable disable

namespace ReceitaFederalImport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReceitaFederalImport.Models.Socio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CnpjBasico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CnpjCpfSocio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpfRepresentanteLegal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataEntradaSociedade")
                        .HasColumnType("datetime2");

                    b.Property<string>("FaixaEtaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificadorSocio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeRepresentante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeSocio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificacaoRepresentante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificacaoSocio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socios");
                });
#pragma warning restore 612, 618
        }
    }
}
