using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Trenerzy")]
public partial class Trenerzy
{
    [Key]
    public int IdTrener { get; set; }

    [StringLength(50)]
    public string? Imie { get; set; }

    [StringLength(50)]
    public string? Nazwisko { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DataUrodzenia { get; set; }

    [StringLength(10)]
    public string? Placa { get; set; }

    [StringLength(50)]
    public string? Specializacja { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NumerTelefonu { get; set; }

    [StringLength(255)]
    public string? AdresEmail { get; set; }

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
    [InverseProperty("TrenerzyKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("TrenerzyKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("TrenerzyKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }

    [InverseProperty("IdTrenerNavigation")]
    public virtual ICollection<OcenyTrenerow> OcenyTrenerows { get; set; } = new List<OcenyTrenerow>();

    [InverseProperty("IdTrenerNavigation")]
    public virtual ICollection<Powiadomienium> Powiadomienia { get; set; } = new List<Powiadomienium>();

    [InverseProperty("IdTreneraNavigation")]
    public virtual ICollection<ZajeciaOfi> ZajeciaOfis { get; set; } = new List<ZajeciaOfi>();
}
