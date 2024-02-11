using Firma.Models.Entities;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class ClientForView
    {


        #region Dane
        public int IdKlienci { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public string? Plec { get; set; }
        public string? Adres { get; set; }
        public string? NumerTelefonu { get; set; }
        public string? AdresEmail { get; set; }
        public DateTime? DataZapisu { get; set; }
        public string? Aktywnosc { get; set; }

        // IdPracownika ?
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
        #endregion
    }
}
