using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.Validatory
{
    public class BiznesValidator:Validator
    {
        public static string SprawdzCenaPrzedzial(Decimal? Cena)
        {
            if (Cena < 0 || Cena > 1000)
                    return "The price must be within the range from 0 to 1000";
            return null;
        }
        public static string SprawdzOcenaPrzedzial(Decimal? Ocena)
        {
            if (Ocena < 0 || Ocena > 5)
                return "The rating must be within the range from 0 to 5.";
            return null;
        }
        public static string SprawdzPensjaPrzedzial(Decimal? Pensja)
        {
            if (Pensja < 0 || Pensja > 10000)
                return "The amount must be within the range from 0 to 10000.";
            return null;
        }
    }
}
