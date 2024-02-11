using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    // ta klase jest po to aby zamiast kluczy obcych w bazie danych wyswietlac ko. dane tabek powiazanych
    public class AttendanceForView
    {
        #region Dane
        public int IdObecnosc { get; set; }

        // Pola zamiast IdKlient
        public string? KlientImie { get; set; }
        public string? KlientNazwisko { get; set; }
        public DateTime? KlientDataUrodzenia { get; set; }

        // Pola zamiast IdZajeciaOfi
        public string? ZajeciaOfiNazwaZajec { get; set; }
        public DateTime? ZajeciaOfiDataRozpoczecia { get; set; }
        public TimeSpan? ZajeciaOfiGodzinaRozpoczecia { get; set; }


        public DateTime? Data { get; set; }
        public string? Obecnosc1 { get; set; }
        public string? Aktywnosc { get; set; }

        // IdPracownika ?
        public string? KtoDodal { get; set; }
        

        public DateTime? KiedyDodane { get; set; }



    
        #endregion
    }
}
