using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Platnosci")]
public partial class Platnosci
{
    [Key]
    public int IdPlatnosci { get; set; }

    public int? IdKlient { get; set; }

    public int? IdKarnet { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DataPlatnosci { get; set; }

    [Column(TypeName = "money")]
    public decimal? Kwota { get; set; }

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

    [ForeignKey("IdKarnet")]
    [InverseProperty("Platnoscis")]
    public virtual Karnety? IdKarnetNavigation { get; set; }

    [ForeignKey("IdKlient")]
    [InverseProperty("Platnoscis")]
    public virtual Klienci? IdKlientNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("PlatnosciKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("PlatnosciKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("PlatnosciKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
