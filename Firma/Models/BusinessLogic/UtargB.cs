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
    public class UtargB:DatabaseClass   
    {
        #region Konstruktor
        public UtargB(GymEntities gymEntities)
            : base(gymEntities)
        {
        }
        #endregion
        #region Funkcje biz

        public decimal? UtargPassOkres(int idKarnety, DateTime dataOd, DateTime dataDo)
        {
            return
            (
                from platnosc in gymEntities.Platnoscis
                join karnet in gymEntities.Karneties on platnosc.IdKarnet equals karnet.IdKarnety
                where
                    karnet.IdKarnety == idKarnety &&
                    platnosc.DataPlatnosci >= dataOd &&
                    platnosc.DataPlatnosci <= dataDo
                select (decimal?)platnosc.Kwota
            ).Sum();
        }

        #endregion  
    }
}
