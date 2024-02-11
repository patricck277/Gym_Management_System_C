using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("OcenyTrenerow")]
public partial class OcenyTrenerow
{
    [Key]
    public int IdOcenyTrenerow { get; set; }

    public int? IdKlient { get; set; }

    public int? IdTrener { get; set; }

    public int? Ocena { get; set; }

    public string? Komentarz { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataOceny { get; set; }

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
    [InverseProperty("OcenyTrenerows")]
    public virtual Klienci? IdKlientNavigation { get; set; }

    [ForeignKey("IdTrener")]
    [InverseProperty("OcenyTrenerows")]
    public virtual Trenerzy? IdTrenerNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("OcenyTrenerowKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("OcenyTrenerowKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("OcenyTrenerowKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
