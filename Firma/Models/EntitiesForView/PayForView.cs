using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class PayForView
    {
        public int IdPlatnosci { get; set; }
        public string? KlientImie { get; set; }
        public string? KlientNazwisko { get; set; }
        public DateTime? KlientDataUrodzenia { get; set; }
        public string? KarnetNazwaKarnetu { get; set; }
        public string? KarnetRodzajKarnetu { get; set; }
        public DateTime? KarnetOkresWaznosci { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public decimal? Kwota { get; set; }
        public string? Aktywnosc { get; set; }
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
    }
}
