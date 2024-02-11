using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class ProductsForView
    {
        public int IdProdukty { get; set; }
        public string? NazwaProduktu { get; set; }
        public decimal? Cena { get; set; }
        public string? IloscDostepna { get; set; }
        public string? Aktywnosc { get; set; }

        // IdPracownika ?
        public string? KtoDodal { get; set; }


        public DateTime? KiedyDodane { get; set; }
    }
}
