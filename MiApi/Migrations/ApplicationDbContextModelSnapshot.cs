﻿// <auto-generated />
using MiApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MiApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiApi.Cervezas", b =>
            {
                b.Property<int>("ID_CERVEZA") 
                    .ValueGeneratedNever()
                    .HasColumnType("NUMBER");

                b.Property<decimal>("GRADUACION")
                    .HasPrecision(5, 2) 
                    .HasColumnType("NUMBER(5,2)");

                b.Property<string>("NOMBRE")
                    .IsRequired()
                    .HasMaxLength(100) 
                    .HasColumnType("NVARCHAR2(100)");

                b.Property<string>("PAIS")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("NVARCHAR2(100)");

                b.HasKey("ID_CERVEZA");

                b.ToTable("CERVEZAS", (string)null);
            });
#pragma warning restore 612, 618
        }
    }
}
