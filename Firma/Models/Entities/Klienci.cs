using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Klienci")]
public partial class Klienci
{
    [Key]
    public int IdKlienci { get; set; }

    [StringLength(50)]
    public string? Imie { get; set; }

    [StringLength(50)]
    public string? Nazwisko { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DataUrodzenia { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Plec { get; set; }

    [StringLength(255)]
    public string? Adres { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NumerTelefonu { get; set; }

    [StringLength(255)]
    public string? AdresEmail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataZapisu { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Aktywnosc { get; set; }

    public int? KtoDodal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KiedyDodane { get; set; }

    public int? KtoZmodifikowal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KiedyZmodifikowane { get; set; }

    public int? KtoUsunal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KiedyUsuniete { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("KlienciKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("KlienciKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("KlienciKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }

    [InverseProperty("IdKlientNavigation")]
    public virtual ICollection<Obecnosc> Obecnoscs { get; set; } = new List<Obecnosc>();

    [InverseProperty("IdKlientNavigation")]
    public virtual ICollection<OcenyTrenerow> OcenyTrenerows { get; set; } = new List<OcenyTrenerow>();

    [InverseProperty("IdKlientNavigation")]
    public virtual ICollection<Platnosci> Platnoscis { get; set; } = new List<Platnosci>();

    [InverseProperty("IdKlientNavigation")]
    public virtual ICollection<Powiadomienium> Powiadomienia { get; set; } = new List<Powiadomienium>();

    [InverseProperty("IdKlientNavigation")]
    public virtual ICollection<Rezerwacje> Rezerwacjes { get; set; } = new List<Rezerwacje>();
}
