using Firma.Models.Context;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class ClientC : DatabaseClass
    {
        #region Constructor
        public ClientC(GymEntities gymEntities)
            : base(gymEntities)
        {
        }
        #endregion
        #region Funkcje biznesowe
        public IQueryable<KeyAndValue> GetClientKeyAndValueItems()
        {
            return
                (
                from Klienci in gymEntities.Kliencis
                select new KeyAndValue
                {
                    Key = Klienci.IdKlienci,
                    Value = Klienci.Imie + " " + Klienci.Nazwisko
                }
                ).ToList().AsQueryable();

        }
        #endregion

    }


}
