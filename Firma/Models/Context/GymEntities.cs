using System;
using System.Collections.Generic;
using Firma.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Context;

public partial class GymEntities : DbContext
{
    public GymEntities()
    {
    }

    public GymEntities(DbContextOptions<GymEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Dostawcy> Dostawcies { get; set; }

    public virtual DbSet<Karnety> Karneties { get; set; }

    public virtual DbSet<Klienci> Kliencis { get; set; }

    public virtual DbSet<Obecnosc> Obecnoscs { get; set; }

    public virtual DbSet<OcenyTrenerow> OcenyTrenerows { get; set; }

    public virtual DbSet<Platnosci> Platnoscis { get; set; }

    public virtual DbSet<Powiadomienium> Powiadomienia { get; set; }

    public virtual DbSet<Pracownicy> Pracownicies { get; set; }

    public virtual DbSet<Produkty> Produkties { get; set; }

    public virtual DbSet<Promocje> Promocjes { get; set; }

    public virtual DbSet<Rezerwacje> Rezerwacjes { get; set; }

    public virtual DbSet<Sprzet> Sprzets { get; set; }

    public virtual DbSet<Trenerzy> Trenerzies { get; set; }

    public virtual DbSet<ZajeciaOfi> ZajeciaOfis { get; set; }

    public virtual DbSet<Zamowienium> Zamowienia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TQKD8U4;TrustServerCertificate=True;Integrated Security=True;Database=Silownia");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dostawcy>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.DostawcyKtoDodalNavigations).HasConstraintName("FK_Dostawcy_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.DostawcyKtoUsunalNavigations).HasConstraintName("FK_Dostawcy_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.DostawcyKtoZmodifikowalNavigations).HasConstraintName("FK_Dostawcy_Pracownicy1");
        });

        modelBuilder.Entity<Karnety>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.KarnetyKtoDodalNavigations).HasConstraintName("FK_Karnety_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.KarnetyKtoUsunalNavigations).HasConstraintName("FK_Karnety_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.KarnetyKtoZmodifikowalNavigations).HasConstraintName("FK_Karnety_Pracownicy1");
        });

        modelBuilder.Entity<Klienci>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.KlienciKtoDodalNavigations).HasConstraintName("FK_Klienci_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.KlienciKtoUsunalNavigations).HasConstraintName("FK_Klienci_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.KlienciKtoZmodifikowalNavigations).HasConstraintName("FK_Klienci_Pracownicy1");
        });

        modelBuilder.Entity<Obecnosc>(entity =>
        {
            entity.HasOne(d => d.IdKlientNavigation).WithMany(p => p.Obecnoscs).HasConstraintName("FK_Obecnosc_Klienci");

            entity.HasOne(d => d.IdZajeciaNavigation).WithMany(p => p.Obecnoscs).HasConstraintName("FK_Obecnosc_ZajeciaOfi");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.ObecnoscKtoDodalNavigations).HasConstraintName("FK_Obecnosc_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.ObecnoscKtoUsunalNavigations).HasConstraintName("FK_Obecnosc_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.ObecnoscKtoZmodifikowalNavigations).HasConstraintName("FK_Obecnosc_Pracownicy1");
        });

        modelBuilder.Entity<OcenyTrenerow>(entity =>
        {
            entity.HasOne(d => d.IdKlientNavigation).WithMany(p => p.OcenyTrenerows).HasConstraintName("FK_OcenyTrenerow_Klienci");

            entity.HasOne(d => d.IdTrenerNavigation).WithMany(p => p.OcenyTrenerows).HasConstraintName("FK_OcenyTrenerow_Trenerzy");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.OcenyTrenerowKtoDodalNavigations).HasConstraintName("FK_OcenyTrenerow_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.OcenyTrenerowKtoUsunalNavigations).HasConstraintName("FK_OcenyTrenerow_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.OcenyTrenerowKtoZmodifikowalNavigations).HasConstraintName("FK_OcenyTrenerow_Pracownicy1");
        });

        modelBuilder.Entity<Platnosci>(entity =>
        {
            entity.HasOne(d => d.IdKarnetNavigation).WithMany(p => p.Platnoscis).HasConstraintName("FK_Platnosci_Karnety");

            entity.HasOne(d => d.IdKlientNavigation).WithMany(p => p.Platnoscis).HasConstraintName("FK_Platnosci_Klienci");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.PlatnosciKtoDodalNavigations).HasConstraintName("FK_Platnosci_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.PlatnosciKtoUsunalNavigations).HasConstraintName("FK_Platnosci_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.PlatnosciKtoZmodifikowalNavigations).HasConstraintName("FK_Platnosci_Pracownicy1");
        });

        modelBuilder.Entity<Powiadomienium>(entity =>
        {
            entity.HasOne(d => d.IdKlientNavigation).WithMany(p => p.Powiadomienia).HasConstraintName("FK_Powiadomienia_Klienci");

            entity.HasOne(d => d.IdTrenerNavigation).WithMany(p => p.Powiadomienia).HasConstraintName("FK_Powiadomienia_Trenerzy");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.PowiadomieniumKtoDodalNavigations).HasConstraintName("FK_Powiadomienia_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.PowiadomieniumKtoUsunalNavigations).HasConstraintName("FK_Powiadomienia_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.PowiadomieniumKtoZmodifikowalNavigations).HasConstraintName("FK_Powiadomienia_Pracownicy1");
        });

        modelBuilder.Entity<Pracownicy>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.InverseKtoDodalNavigation).HasConstraintName("FK_Pracownicy_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.InverseKtoUsunalNavigation).HasConstraintName("FK_Pracownicy_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.InverseKtoZmodifikowalNavigation).HasConstraintName("FK_Pracownicy_Pracownicy1");
        });

        modelBuilder.Entity<Produkty>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.ProduktyKtoDodalNavigations).HasConstraintName("FK_Produkty_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.ProduktyKtoUsunalNavigations).HasConstraintName("FK_Produkty_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.ProduktyKtoZmodifikowalNavigations).HasConstraintName("FK_Produkty_Pracownicy1");
        });

        modelBuilder.Entity<Promocje>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.PromocjeKtoDodalNavigations).HasConstraintName("FK_Promocje_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.PromocjeKtoUsunalNavigations).HasConstraintName("FK_Promocje_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.PromocjeKtoZmodifikowalNavigations).HasConstraintName("FK_Promocje_Pracownicy1");
        });

        modelBuilder.Entity<Rezerwacje>(entity =>
        {
            entity.HasOne(d => d.IdKlientNavigation).WithMany(p => p.Rezerwacjes).HasConstraintName("FK_Rezerwacje_Klienci");

            entity.HasOne(d => d.IdZajeciaNavigation).WithMany(p => p.Rezerwacjes).HasConstraintName("FK_Rezerwacje_ZajeciaOfi");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.RezerwacjeKtoDodalNavigations).HasConstraintName("FK_Rezerwacje_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.RezerwacjeKtoUsunalNavigations).HasConstraintName("FK_Rezerwacje_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.RezerwacjeKtoZmodifikowalNavigations).HasConstraintName("FK_Rezerwacje_Pracownicy1");
        });

        modelBuilder.Entity<Sprzet>(entity =>
        {
            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.SprzetKtoDodalNavigations).HasConstraintName("FK_Sprzet_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.SprzetKtoUsunalNavigations).HasConstraintName("FK_Sprzet_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.SprzetKtoZmodifikowalNavigations).HasConstraintName("FK_Sprzet_Pracownicy1");
        });

        modelBuilder.Entity<Trenerzy>(entity =>
        {
            entity.Property(e => e.Placa).IsFixedLength();

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.TrenerzyKtoDodalNavigations).HasConstraintName("FK_Trenerzy_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.TrenerzyKtoUsunalNavigations).HasConstraintName("FK_Trenerzy_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.TrenerzyKtoZmodifikowalNavigations).HasConstraintName("FK_Trenerzy_Pracownicy1");
        });

        modelBuilder.Entity<ZajeciaOfi>(entity =>
        {
            entity.HasOne(d => d.IdTreneraNavigation).WithMany(p => p.ZajeciaOfis).HasConstraintName("FK_ZajeciaOfi_Trenerzy");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.ZajeciaOfiKtoDodalNavigations).HasConstraintName("FK_ZajeciaOfi_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.ZajeciaOfiKtoUsunalNavigations).HasConstraintName("FK_ZajeciaOfi_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.ZajeciaOfiKtoZmodifikowalNavigations).HasConstraintName("FK_ZajeciaOfi_Pracownicy1");
        });

        modelBuilder.Entity<Zamowienium>(entity =>
        {
            entity.HasOne(d => d.IdDostawcaNavigation).WithMany(p => p.Zamowienia).HasConstraintName("FK_Zamowienia_Dostawcy");

            entity.HasOne(d => d.KtoDodalNavigation).WithMany(p => p.ZamowieniumKtoDodalNavigations).HasConstraintName("FK_Zamowienia_Pracownicy");

            entity.HasOne(d => d.KtoUsunalNavigation).WithMany(p => p.ZamowieniumKtoUsunalNavigations).HasConstraintName("FK_Zamowienia_Pracownicy2");

            entity.HasOne(d => d.KtoZmodifikowalNavigation).WithMany(p => p.ZamowieniumKtoZmodifikowalNavigations).HasConstraintName("FK_Zamowienia_Pracownicy1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
