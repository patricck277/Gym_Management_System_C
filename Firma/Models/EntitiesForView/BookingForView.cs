using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class BookingForView
    {
        #region DAne
        public int IdRezerwacje { get; set; }

        // Pola zamiast IdKlient
        public string? KlientImie { get; set; }
        public string? KlientNazwisko { get; set; }
        public DateTime? KlientDataUrodzenia { get; set; }

        // Pola zamiast IdZajeciaOfi
        public string? ZajeciaOfiNazwaZajec { get; set; }
        public DateTime? ZajeciaOfiDataRozpoczecia { get; set; }
        public TimeSpan? ZajeciaOfiGodzinaRozpoczecia { get; set; }

        public DateTime? Data { get; set; }
        public string? Potwierdzenie { get; set; }
        public string? Aktywnosc { get; set; }

        // IdPracownika
        public string? KtoDodal { get; set; }


        public DateTime? KiedyDodane { get; set; }
        #endregion
    }
}
