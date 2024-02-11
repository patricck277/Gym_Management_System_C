using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class PassForView
    {
        public int IdKarnety { get; set; }
        public string? NazwaKarnetu { get; set; }
        public decimal? Cena { get; set; }
        public DateTime? OkresWaznosci { get; set; }
        public string? RodzajKarnetu { get; set; }
        public string? Aktywnosc { get; set; }
        // IdPracownika ?
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
    }
}
