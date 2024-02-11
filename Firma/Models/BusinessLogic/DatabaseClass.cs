using Firma.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{

   public class DatabaseClass
    {
        #region Fields
        protected GymEntities gymEntities;
        #endregion
        #region Constructors
        public DatabaseClass(GymEntities gymEntities)
        {
            this.gymEntities = gymEntities;
        }
        
        #endregion
    }
}
