using Firma.Helpers;
using Firma.Models.Context;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class DiscountViewModel : WszystkieViewModels<DiscountForView>
    {

        #region  Constructor
        public DiscountViewModel()
        : base()
        {
            base.DisplayName = "Discount";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<DiscountForView>
            (
                from promocje in gymEntities.Promocjes select new DiscountForView

                {

                    IdPromocje = promocje.IdPromocje,
                    NazwaPromocji = promocje.NazwaPromocji,
                    OpisPromocji = promocje.OpisPromocji,
                    DataRozpoczecia = promocje.DataRozpoczecia,
                    DataZakonczenia = promocje.DataZakonczenia,
                    Aktywnosc = promocje.Aktywnosc,
                    KtoDodal = promocje.KtoDodalNavigation.IdPracownicy + " " + promocje.KtoDodalNavigation.Imie + " " + promocje.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = promocje.KiedyDodane

                }
             
             
             );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa promocji" };
        }
        public override void sort()
        {

            if (SortField == "Nazwa promocji")
                List = new ObservableCollection<DiscountForView>(List.OrderBy(item => item.NazwaPromocji));
  

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa promocji" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<DiscountForView>(List.Where(item => item.NazwaPromocji
           != null && item.NazwaPromocji.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
