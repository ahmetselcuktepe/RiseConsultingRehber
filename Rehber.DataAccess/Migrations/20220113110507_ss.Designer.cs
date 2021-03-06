// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rehber.DataAccess;

namespace Rehber.DataAccess.Migrations
{
    [DbContext(typeof(RehberDBContext))]
    [Migration("20220113110507_ss")]
    partial class ss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Rehber.Entities.RehberK", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Firma")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Kaldirma")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RehberKs");
                });

            modelBuilder.Entity("Rehber.Entities.RehberKDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Deger")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Kaldirma")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KisiId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("RehberKId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RehberKId");

                    b.ToTable("RehberKDetails");
                });

            modelBuilder.Entity("Rehber.Entities.RehberKDetail", b =>
                {
                    b.HasOne("Rehber.Entities.RehberK", "RehberK")
                        .WithMany("RehberKDetails")
                        .HasForeignKey("RehberKId");

                    b.Navigation("RehberK");
                });

            modelBuilder.Entity("Rehber.Entities.RehberK", b =>
                {
                    b.Navigation("RehberKDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
