        using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("ZajeciaOfi")]
public partial class ZajeciaOfi
{
    [Key]
    public int IdZajecia { get; set; }

    [StringLength(50)]
    public string? NazwaZajec { get; set; }

    public int? IdTrenera { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DataRozpoczecia { get; set; }

    public TimeSpan? GodzinaRozpoczecia { get; set; }

    public TimeSpan? GodzinaZakonczenia { get; set; }

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

    [ForeignKey("IdTrenera")]
    [InverseProperty("ZajeciaOfis")]
    public virtual Trenerzy? IdTreneraNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("ZajeciaOfiKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("ZajeciaOfiKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("ZajeciaOfiKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }

    [InverseProperty("IdZajeciaNavigation")]
    public virtual ICollection<Obecnosc> Obecnoscs { get; set; } = new List<Obecnosc>();

    [InverseProperty("IdZajeciaNavigation")]
    public virtual ICollection<Rezerwacje> Rezerwacjes { get; set; } = new List<Rezerwacje>();
}
