using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Karnety")]
public partial class Karnety
{
    [Key]
    public int IdKarnety { get; set; }

    [StringLength(50)]
    public string? NazwaKarnetu { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cena { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OkresWaznosci { get; set; }

    [StringLength(50)]
    public string? RodzajKarnetu { get; set; }

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
    [InverseProperty("KarnetyKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("KarnetyKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("KarnetyKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }

    [InverseProperty("IdKarnetNavigation")]
    public virtual ICollection<Platnosci> Platnoscis { get; set; } = new List<Platnosci>();
   
}
