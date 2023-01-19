﻿// <auto-generated />
using System;
using Meseriasul1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Meseriasul1.Migrations
{
    [DbContext(typeof(Meseriasul1Context))]
    [Migration("20230119135550_migratie5")]
    partial class migratie5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Meseriasul1.Models.Meserias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Experienta")
                        .HasColumnType("int");

                    b.Property<string>("Meserie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgramareID")
                        .HasColumnType("int");

                    b.Property<int?>("ServiciuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProgramareID");

                    b.HasIndex("ServiciuID");

                    b.ToTable("Meserias");
                });

            modelBuilder.Entity("Meseriasul1.Models.Programare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Dataprogramarii")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Programare");
                });

            modelBuilder.Entity("Meseriasul1.Models.Serviciu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NumeServiciu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProgramareID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProgramareID");

                    b.ToTable("Servicii");
                });

            modelBuilder.Entity("Meseriasul1.Models.Meserias", b =>
                {
                    b.HasOne("Meseriasul1.Models.Programare", "Programare")
                        .WithMany("Meseriasi")
                        .HasForeignKey("ProgramareID");

                    b.HasOne("Meseriasul1.Models.Serviciu", "Serviciu")
                        .WithMany("Meseriasi")
                        .HasForeignKey("ServiciuID");

                    b.Navigation("Programare");

                    b.Navigation("Serviciu");
                });

            modelBuilder.Entity("Meseriasul1.Models.Serviciu", b =>
                {
                    b.HasOne("Meseriasul1.Models.Programare", "Programare")
                        .WithMany("Servicii")
                        .HasForeignKey("ProgramareID");

                    b.Navigation("Programare");
                });

            modelBuilder.Entity("Meseriasul1.Models.Programare", b =>
                {
                    b.Navigation("Meseriasi");

                    b.Navigation("Servicii");
                });

            modelBuilder.Entity("Meseriasul1.Models.Serviciu", b =>
                {
                    b.Navigation("Meseriasi");
                });
#pragma warning restore 612, 618
        }
    }
}