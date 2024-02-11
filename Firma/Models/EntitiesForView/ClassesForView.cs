using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class ClassesForView
    {
        #region Dane
        public int IdZajecia { get; set; }
        public string? NazwaZajec { get; set; }
        //Id Trenera
        public string? TrenerImie { get; set; }
        public string? TrenerNazwisko { get; set; }
        public string? TrenerSpecializacja { get; set; }

        public DateTime? DataRozpoczecia { get; set; }
        public TimeSpan? GodzinaRozpoczecia { get; set; }
        public TimeSpan? GodzinaZakonczenia { get; set; }
        public string? Aktywnosc { get; set; }
        // IdPracownika ?
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
        #endregion
    }
}
