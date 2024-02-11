using Firma.Models.Context;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class HowC : DatabaseClass
    {
        #region Konstruktor
        public HowC(GymEntities gymEntities)
            : base(gymEntities)
        {
        }
        #endregion
        #region Funkcje biz

        public int RaportWynikC(int IdKlienci, DateTime dataOd, DateTime dataDo)
        {
            return
            (
                from Obecnosc in gymEntities.Obecnoscs
                where
                    Obecnosc.IdKlientNavigation.IdKlienci == IdKlienci &&
                    Obecnosc.Data >= dataOd &&
                    Obecnosc.Data <= dataDo
                select Obecnosc
            ).Count();
        }

        #endregion  
    }
}
