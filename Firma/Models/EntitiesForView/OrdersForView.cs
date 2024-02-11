using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class OrdersForView
    {
        public int IdZamowienia { get; set; }
        // Dostawca
        public string DostawcaNazwaDostawcy { get; set; }
        public string DostawcaKontkat { get; set; }
        public string DostawcaAdres { get; set; }

        public DateTime? DataZamowienia { get; set; }
        public string? Status { get; set; }
        public string? Aktywnosc { get; set; }
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }


    }
}
