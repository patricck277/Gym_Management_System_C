using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class SuppliersForView
    {
        public int IdDostawcy { get; set; }
        public string? NazwaDostawcy { get; set; }
        public string? Kontakt { get; set; }
        public string? Adres { get; set; }
        public string? Aktywnosc { get; set; }

        // IdPracownika
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
    }
}
