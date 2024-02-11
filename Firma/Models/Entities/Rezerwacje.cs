using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Rezerwacje")]
public partial class Rezerwacje
{
    [Key]
    public int IdRezerwacje { get; set; }

    public int? IdKlient { get; set; }

    public int? IdZajecia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Data { get; set; }

    [StringLength(10)]
    public string? Potwierdzenie { get; set; }

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
    [InverseProperty("Rezerwacjes")]
    public virtual Klienci? IdKlientNavigation { get; set; }

    [ForeignKey("IdZajecia")]
    [InverseProperty("Rezerwacjes")]
    public virtual ZajeciaOfi? IdZajeciaNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("RezerwacjeKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("RezerwacjeKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("RezerwacjeKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
