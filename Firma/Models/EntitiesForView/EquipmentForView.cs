using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class EquipmentForView
    {
        public int IdSprzet { get; set; }
        public string? NazwaSprzetu { get; set; }
        public string? Producent { get; set; }
        public DateTime? RokProdukcji { get; set; }
        public int? IloscDostepnych { get; set; }
        public string? Aktywnosc { get; set; }
        public string? KtoDodal { get; set; }
        public DateTime? KiedyDodane { get; set; }
    }
}
