using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Sprzet")]
public partial class Sprzet
{
    [Key]
    public int IdSprzet { get; set; }

    [StringLength(50)]
    public string? NazwaSprzetu { get; set; }

    [StringLength(50)]
    public string? Producent { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RokProdukcji { get; set; }

    public int? IloscDostepnych { get; set; }

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

    [ForeignKey("KtoDodal")]
    [InverseProperty("SprzetKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("SprzetKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("SprzetKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
