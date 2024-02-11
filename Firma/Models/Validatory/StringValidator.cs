using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.Validatory
{
    public class StringValidator:Validator   
    {
        //statyczna fukncja jest statyczna
        //zwraca stringa z kom. bledu
        //funkcja sprawdza czy parametr zaczyna sie duza litera
        
        public static string SprawdzCzyZaczynaOdDuzej(string wartosc)
        {
            try
            {
                if(!char.IsUpper(wartosc,0)) //sprawdzamy czy wartosc na 1 poz nie jest duza litera
                {
                    return "The first letter must be uppercase.";
                }

            }
            catch (Exception)
            {

            }
            return null;
        }
    }
}
