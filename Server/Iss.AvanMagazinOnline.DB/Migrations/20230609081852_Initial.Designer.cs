﻿// <auto-generated />
using System;
using ConsoleApp5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20230609081852_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Producator", b =>
                {
                    b.Property<int>("ProducatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducatorId"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime?>("DataInceput")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DataSfarsit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("'2078-12-31 00:00:00.0000000'");

                    b.Property<string>("ICalculator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(32)")
                        .HasDefaultValueSql("host_name()");

                    b.Property<DateTime?>("IData")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("IUtilizator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(32)")
                        .HasDefaultValueSql("suser_sname()");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<int?>("ProducatorIdCt")
                        .HasColumnType("int");

                    b.Property<byte[]>("Rv")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UCalculator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(32)")
                        .HasDefaultValueSql("host_name()");

                    b.Property<DateTime?>("UData")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UUtilizator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(32)")
                        .HasDefaultValueSql("suser_sname()");

                    b.HasKey("ProducatorId");

                    b.ToTable("tProducator");
                });
#pragma warning restore 612, 618
        }
    }
}
