using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class FeedbackForView
    {
        public int IdOcenyTrenerow { get; set; }
        public string? KlientImie { get; set; }
        public string? KlientNazwisko { get; set; }
        public DateTime? KlientDataUrodzenia { get; set; }
        
        public string? TrenerImie { get; set; }
        public string? TrenerNazwisko { get; set; }
        public string? TrenerSpecjalizacja { get; set; }
        public int? Ocena { get; set; }
        public string? Komentarz { get; set; }
        public DateTime? DataOceny { get; set; }
        public string? Aktywnosc { get; set; }
        // IdPracownika ?
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }



    }
}
