using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class DiscountForView
    {
        public int IdPromocje { get; set; }
        public string? NazwaPromocji { get; set; }
        public string? OpisPromocji { get; set; }
        public DateTime? DataRozpoczecia { get; set; }
        public DateTime? DataZakonczenia { get; set; }
        public string? Aktywnosc { get; set; }

        // IdPracownika ?
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
    }
}
