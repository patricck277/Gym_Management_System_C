using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Firma.Models.Entities;

[Table("Pracownicy")]
public partial class Pracownicy
{
    [Key]
    public int IdPracownicy { get; set; }

    [StringLength(50)]
    public string? Imie { get; set; }

    [StringLength(50)]
    public string? Nazwisko { get; set; }

    [StringLength(50)]
    public string? Stanowisko { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DataZatrudnienia { get; set; }

    [Column(TypeName = "money")]
    public decimal? Pensja { get; set; }

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

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Dostawcy> DostawcyKtoDodalNavigations { get; set; } = new List<Dostawcy>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Dostawcy> DostawcyKtoUsunalNavigations { get; set; } = new List<Dostawcy>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Dostawcy> DostawcyKtoZmodifikowalNavigations { get; set; } = new List<Dostawcy>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Pracownicy> InverseKtoDodalNavigation { get; set; } = new List<Pracownicy>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Pracownicy> InverseKtoUsunalNavigation { get; set; } = new List<Pracownicy>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Pracownicy> InverseKtoZmodifikowalNavigation { get; set; } = new List<Pracownicy>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Karnety> KarnetyKtoDodalNavigations { get; set; } = new List<Karnety>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Karnety> KarnetyKtoUsunalNavigations { get; set; } = new List<Karnety>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Karnety> KarnetyKtoZmodifikowalNavigations { get; set; } = new List<Karnety>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Klienci> KlienciKtoDodalNavigations { get; set; } = new List<Klienci>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Klienci> KlienciKtoUsunalNavigations { get; set; } = new List<Klienci>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Klienci> KlienciKtoZmodifikowalNavigations { get; set; } = new List<Klienci>();

    [ForeignKey("KtoDodal")]
    [InverseProperty("InverseKtoDodalNavigation")]
    public virtual Pracownicy? KtoDodalNavigation { get; set; }

    [ForeignKey("KtoUsunal")]
    [InverseProperty("InverseKtoUsunalNavigation")]
    public virtual Pracownicy? KtoUsunalNavigation { get; set; }

    [ForeignKey("KtoZmodifikowal")]
    [InverseProperty("InverseKtoZmodifikowalNavigation")]
    public virtual Pracownicy? KtoZmodifikowalNavigation { get; set; }

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Obecnosc> ObecnoscKtoDodalNavigations { get; set; } = new List<Obecnosc>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Obecnosc> ObecnoscKtoUsunalNavigations { get; set; } = new List<Obecnosc>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Obecnosc> ObecnoscKtoZmodifikowalNavigations { get; set; } = new List<Obecnosc>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<OcenyTrenerow> OcenyTrenerowKtoDodalNavigations { get; set; } = new List<OcenyTrenerow>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<OcenyTrenerow> OcenyTrenerowKtoUsunalNavigations { get; set; } = new List<OcenyTrenerow>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<OcenyTrenerow> OcenyTrenerowKtoZmodifikowalNavigations { get; set; } = new List<OcenyTrenerow>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Platnosci> PlatnosciKtoDodalNavigations { get; set; } = new List<Platnosci>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Platnosci> PlatnosciKtoUsunalNavigations { get; set; } = new List<Platnosci>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Platnosci> PlatnosciKtoZmodifikowalNavigations { get; set; } = new List<Platnosci>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Powiadomienium> PowiadomieniumKtoDodalNavigations { get; set; } = new List<Powiadomienium>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Powiadomienium> PowiadomieniumKtoUsunalNavigations { get; set; } = new List<Powiadomienium>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Powiadomienium> PowiadomieniumKtoZmodifikowalNavigations { get; set; } = new List<Powiadomienium>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Produkty> ProduktyKtoDodalNavigations { get; set; } = new List<Produkty>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Produkty> ProduktyKtoUsunalNavigations { get; set; } = new List<Produkty>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Produkty> ProduktyKtoZmodifikowalNavigations { get; set; } = new List<Produkty>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Promocje> PromocjeKtoDodalNavigations { get; set; } = new List<Promocje>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Promocje> PromocjeKtoUsunalNavigations { get; set; } = new List<Promocje>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Promocje> PromocjeKtoZmodifikowalNavigations { get; set; } = new List<Promocje>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Rezerwacje> RezerwacjeKtoDodalNavigations { get; set; } = new List<Rezerwacje>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Rezerwacje> RezerwacjeKtoUsunalNavigations { get; set; } = new List<Rezerwacje>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Rezerwacje> RezerwacjeKtoZmodifikowalNavigations { get; set; } = new List<Rezerwacje>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Sprzet> SprzetKtoDodalNavigations { get; set; } = new List<Sprzet>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Sprzet> SprzetKtoUsunalNavigations { get; set; } = new List<Sprzet>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Sprzet> SprzetKtoZmodifikowalNavigations { get; set; } = new List<Sprzet>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Trenerzy> TrenerzyKtoDodalNavigations { get; set; } = new List<Trenerzy>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Trenerzy> TrenerzyKtoUsunalNavigations { get; set; } = new List<Trenerzy>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Trenerzy> TrenerzyKtoZmodifikowalNavigations { get; set; } = new List<Trenerzy>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<ZajeciaOfi> ZajeciaOfiKtoDodalNavigations { get; set; } = new List<ZajeciaOfi>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<ZajeciaOfi> ZajeciaOfiKtoUsunalNavigations { get; set; } = new List<ZajeciaOfi>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<ZajeciaOfi> ZajeciaOfiKtoZmodifikowalNavigations { get; set; } = new List<ZajeciaOfi>();

    [InverseProperty("KtoDodalNavigation")]
    public virtual ICollection<Zamowienium> ZamowieniumKtoDodalNavigations { get; set; } = new List<Zamowienium>();

    [InverseProperty("KtoUsunalNavigation")]
    public virtual ICollection<Zamowienium> ZamowieniumKtoUsunalNavigations { get; set; } = new List<Zamowienium>();

    [InverseProperty("KtoZmodifikowalNavigation")]
    public virtual ICollection<Zamowienium> ZamowieniumKtoZmodifikowalNavigations { get; set; } = new List<Zamowienium>();
}
