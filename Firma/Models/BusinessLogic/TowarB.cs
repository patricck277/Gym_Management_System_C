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
    public class TowarB:DatabaseClass
    {
        #region Constructor
        public TowarB(GymEntities gymEntities)
            : base(gymEntities)
        {
        }
        #endregion
        #region Funkcje biznesowe
        public IQueryable<KeyAndValue> GetPassKeyAndValueItems()
        {
            return
                (
                from karnety in gymEntities.Karneties
                select new KeyAndValue
                {
                    Key = karnety.IdKarnety,
                    Value = karnety.NazwaKarnetu + " " + karnety.Cena
                }
                ).ToList().AsQueryable();

        }
        #endregion

    }


}
