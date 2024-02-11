using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Obecnosc")]
public partial class Obecnosc
{
    [Key]
    public int IdObecnosc { get; set; }

    public int? IdKlient { get; set; }

    public int? IdZajecia { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Data { get; set; }

    [Column("Obecnosc")]
    [StringLength(10)]
    public string? Obecnosc1 { get; set; }

    [StringLength(10)]
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

    [ForeignKey("IdKlient")]
    [InverseProperty("Obecnoscs")]
    public virtual Klienci? IdKlientNavigation { get; set; }

    [ForeignKey("IdZajecia")]
    [InverseProperty("Obecnoscs")]
    public virtual ZajeciaOfi? IdZajeciaNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("ObecnoscKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("ObecnoscKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("ObecnoscKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
