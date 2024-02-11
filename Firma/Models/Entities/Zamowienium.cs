using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

public partial class Zamowienium
{
    [Key]
    public int IdZamowienia { get; set; }

    public int? IdDostawca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataZamowienia { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

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

    [ForeignKey("IdDostawca")]
    [InverseProperty("Zamowienia")]
    public virtual Dostawcy? IdDostawcaNavigation { get; set; }

    [ForeignKey("KtoDodal")]
    [InverseProperty("ZamowieniumKtoDodalNavigations")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("ZamowieniumKtoUsunalNavigations")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("ZamowieniumKtoZmodifikowalNavigations")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }
}
