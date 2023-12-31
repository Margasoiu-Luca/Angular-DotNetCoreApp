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
    [Migration("20230610163451_Ninght")]
    partial class Ninght
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.CategorieProdus", b =>
                {
                    b.Property<int>("CategorieProdusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategorieProdusId"));

                    b.Property<string>("DenumireCategorieProdus")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

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

                    b.HasKey("CategorieProdusId");

                    b.ToTable("tnCategorieProdus");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Comanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComandaId"));

                    b.Property<decimal>("CostLivrare")
                        .HasColumnType("decimal(28,4)");

                    b.Property<decimal>("CostTotalProduse")
                        .HasColumnType("decimal(28,4)");

                    b.Property<int>("CumparatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataComanda")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("Numar")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

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

                    b.HasKey("ComandaId");

                    b.HasIndex("CumparatorId");

                    b.ToTable("tComanda");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Cumparator", b =>
                {
                    b.Property<int>("CumparatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CumparatorId"));

                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime>("DataInceput")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DataNastere")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("'2078-12-31 00:00:00.0000000'");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

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
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(32)");

                    b.Property<byte[]>("Rv")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("TelefonMobil")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<byte>("TipPersoana")
                        .HasColumnType("tinyint");

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

                    b.HasKey("CumparatorId");

                    b.ToTable("tCumparator");
                });

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

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Produs", b =>
                {
                    b.Property<int>("ProdusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdusId"));

                    b.Property<int>("CategorieProdusId")
                        .HasColumnType("int");

                    b.Property<decimal>("CostProdus")
                        .HasColumnType("decimal(9,2)");

                    b.Property<DateTime>("DataInceput")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DataSfarsit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("'2078-12-31 00:00:00.0000000'");

                    b.Property<string>("DenumireProdus")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("DescriereProdus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("ProducatorId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdusIdCt")
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

                    b.HasKey("ProdusId");

                    b.HasIndex("CategorieProdusId");

                    b.HasIndex("ProducatorId");

                    b.ToTable("tProdus");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.ProdusStoc", b =>
                {
                    b.Property<int>("ProdusStocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdusStocId"));

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

                    b.Property<int>("ProdusIdCt")
                        .HasColumnType("int");

                    b.Property<byte[]>("Rv")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<decimal>("Stoc")
                        .HasColumnType("decimal(9,2)");

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

                    b.HasKey("ProdusStocId");

                    b.ToTable("tProdusStoc");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Comanda", b =>
                {
                    b.HasOne("Iss.AvanMagazinOnline.DB.Models.Cumparator", "Cumparator")
                        .WithMany("Comenzi")
                        .HasForeignKey("CumparatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AvnLeanring_tComanda_CumparatorId");

                    b.Navigation("Cumparator");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Produs", b =>
                {
                    b.HasOne("Iss.AvanMagazinOnline.DB.Models.CategorieProdus", "CategorieProdus")
                        .WithMany("Produse")
                        .HasForeignKey("CategorieProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AvnLeanring_tProdus_CategorieProdus");

                    b.HasOne("Iss.AvanMagazinOnline.DB.Models.Producator", "Producator")
                        .WithMany("Produse")
                        .HasForeignKey("ProducatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AvnLeanring_tProdus_ProdusId");

                    b.Navigation("CategorieProdus");

                    b.Navigation("Producator");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.CategorieProdus", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Cumparator", b =>
                {
                    b.Navigation("Comenzi");
                });

            modelBuilder.Entity("Iss.AvanMagazinOnline.DB.Models.Producator", b =>
                {
                    b.Navigation("Produse");
                });
#pragma warning restore 612, 618
        }
    }
}
