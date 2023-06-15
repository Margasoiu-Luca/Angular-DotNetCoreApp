using Iss.AvanMagazinOnline.DB.Models;
using Laraue.EfCoreTriggers.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Data
{
    internal class EFContext : DbContext
    {

        private const string connectionString = "Data Source=UNIT34\\SQL2019;Initial Catalog=Iss.AvanMagazinOnline;Integrated Security=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producator>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.ICalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.IUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.UData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.UCalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.UUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.DataInceput)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Producator>()
                .Property(b => b.DataSfarsit)
                .HasDefaultValueSql("'2078-12-31 00:00:00.0000000'");
            modelBuilder.Entity<Producator>()
                .HasMany(b => b.Produse)
                .WithOne(b => b.Producator)
                .HasForeignKey(b => b.ProducatorId)
                .HasConstraintName("FK_AvnLeanring_tProdus_ProdusId")
                .IsRequired();
            modelBuilder.Entity<Producator>()
                .ToTable(tb => tb.HasTrigger("ProducatorIdCtUpdate"));


            modelBuilder.Entity<CategorieProdus>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<CategorieProdus>()
                .Property(b => b.ICalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<CategorieProdus>()
                .Property(b => b.IUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<CategorieProdus>()
                .Property(b => b.UData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<CategorieProdus>()
                .Property(b => b.UCalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<CategorieProdus>()
                .Property(b => b.UUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<CategorieProdus>()
                .HasMany(b => b.Produse)
                .WithOne(b => b.CategorieProdus)
                .HasForeignKey(b => b.CategorieProdusId)
                .HasConstraintName("FK_AvnLeanring_tProdus_CategorieProdus")
                .IsRequired();




            modelBuilder.Entity<Produs>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.ICalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.IUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.UData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.UCalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.UUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.DataInceput)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Produs>()
                .Property(b => b.DataSfarsit)
                .HasDefaultValueSql("'2078-12-31 00:00:00.0000000'");
            modelBuilder.Entity<Produs>()
                .HasOne(b => b.CategorieProdus)
                .WithMany(b => b.Produse)
                .HasForeignKey(b => b.CategorieProdusId)
                .HasConstraintName("FK_AvnLeanring_tProdus_CategorieProdus")
                .IsRequired();
            modelBuilder.Entity<Produs>()
                .HasOne(b => b.Producator)
                .WithMany(b => b.Produse)
                .HasForeignKey(b => b.ProducatorId)
                .HasConstraintName("FK_AvnLeanring_tProdus_ProdusId")
                .IsRequired();
            modelBuilder.Entity<Produs>()
                .ToTable(tb => tb.HasTrigger("ProdusIdCtUpdate"));


            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.ICalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.IUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.UData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.UCalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<ProdusStoc>()
                .Property(b => b.UUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<ProdusStoc>()
                .HasIndex(b => b.ProdusIdCt)
                .IsUnique();


            modelBuilder.Entity<Cumparator>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.ICalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.IUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.UData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.UCalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.UUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.DataInceput)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Cumparator>()
                .Property(b => b.DataSfarsit)
                .HasDefaultValueSql("'2078-12-31 00:00:00.0000000'");
            modelBuilder.Entity<Cumparator>()
                .HasMany(b => b.Comenzi)
                .WithOne(b => b.Cumparator)
                .HasForeignKey(b => b.CumparatorId)
                .HasConstraintName("FK_AvnLeanring_tComanda_CumparatorId")
                .IsRequired();
            modelBuilder.Entity<Cumparator>()
                .ToTable(tb => tb.HasTrigger("CumparatorIdCtUpdate"));


            modelBuilder.Entity<Comanda>()
                .Property(b => b.IData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Comanda>()
                .Property(b => b.ICalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Comanda>()
                .Property(b => b.IUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Comanda>()
                .Property(b => b.UData)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Comanda>()
                .Property(b => b.UCalculator)
                .HasDefaultValueSql("host_name()");
            modelBuilder.Entity<Comanda>()
                .Property(b => b.UUtilizator)
                .HasDefaultValueSql("suser_sname()");
            modelBuilder.Entity<Comanda>()
                .HasOne(b => b.Cumparator)
                .WithMany(b => b.Comenzi)
                .HasForeignKey(b => b.CumparatorId)
                .HasConstraintName("FK_AvnLeanring_tComanda_CumparatorId")
                .IsRequired();
        }
        public DbSet<Producator> Producatori { get; set; }
        public DbSet<CategorieProdus> CategoriiProdus { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<ProdusStoc> ProduseStoc { get; set; }
        public DbSet<Cumparator> Cumparator { get; set; }

        public DbSet<Comanda> Comenzi { get; set; }

    }
}
