using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class TrainersForView
    {
        public int IdTrener { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public DateTime? DataUrodzenia { get; set; }    
        public string? Specializacja { get; set; }
        public string? NumerTelefonu { get; set; }
        public string? AdresEmail { get; set; }
        public string? Aktywnosc { get; set; }
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
    }
}
