using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

public partial class Powiadomienium
{
    [Key]
    public int IdPowiadomienia { get; set; }

    public int? IdKlient { get; set; }

    public int? IdTrener { get; set; }

    public string? TrescPowiadomienia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataWyslania { get; set; }

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
    [InverseProperty("Powiadomienia")]
    public virtual Klienci? IdKlientNavigation { get; set; }

    [ForeignKey("IdTrener")]
    [InverseProperty("Powiadomienia")]
    public virtual Trenerzy? IdTrenerNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("PowiadomieniumKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("PowiadomieniumKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("PowiadomieniumKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
