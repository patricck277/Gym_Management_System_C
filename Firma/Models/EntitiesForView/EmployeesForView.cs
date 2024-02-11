using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class EmployeesForView
    {
        public int IdPracownicy { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public string? Stanowisko { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public decimal? Pensja { get; set; }
        public string? Aktywnosc { get; set; }
       

        // IdPracownika ?
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }

    }
}
