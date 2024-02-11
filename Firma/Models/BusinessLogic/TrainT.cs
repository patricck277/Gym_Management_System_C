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
    public class TrainT : DatabaseClass
    {
        #region Constructor
        public TrainT(GymEntities gymEntities)
            : base(gymEntities)
        {
        }
        #endregion
        #region Funkcje biznesowe
        public IQueryable<KeyAndValue> GetTrainerKeyAndValueItems()
        {
            return
                (
                from Trenerzy in gymEntities.Trenerzies
                select new KeyAndValue
                {
                    Key = Trenerzy.IdTrener,
                    Value = Trenerzy.Imie + " " + Trenerzy.Nazwisko
                }
                ).ToList().AsQueryable();

        }
        #endregion

    }


}
