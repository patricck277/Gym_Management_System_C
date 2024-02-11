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
    public class SuppliersViewModel : WszystkieViewModels<SuppliersForView>
    {

        #region  Constructor
        public SuppliersViewModel()
        : base()
        {
            base.DisplayName = "Suppliers";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<SuppliersForView>
            (from dostawcy in gymEntities.Dostawcies select new SuppliersForView

            {
                IdDostawcy = dostawcy.IdDostawcy,
                NazwaDostawcy = dostawcy.NazwaDostawcy,
                Adres = dostawcy.Adres,
                Kontakt = dostawcy.Kontakt,
                Aktywnosc = dostawcy.Aktywnosc,
                KtoDodal = dostawcy.KtoDodalNavigation.IdPracownicy + " " + dostawcy.KtoDodalNavigation.Imie + " " + dostawcy.KtoDodalNavigation.Nazwisko,
                KiedyDodane = dostawcy.KiedyDodane

            }
             
             );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa Dostawcy" };
        }
        public override void sort()
        {

            if (SortField == "Nazwa Dostawcy")
                List = new ObservableCollection<SuppliersForView>(List.OrderBy(item => item.NazwaDostawcy));


        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa Dostawcy", "Kontakt" };
        }
        public override void find()
        {
            if (FindField == "Nazwa Dostawcy")
                List = new ObservableCollection<SuppliersForView>(List.Where(item => item.NazwaDostawcy
           != null && item.NazwaDostawcy.StartsWith(FindTextBox)));
            if (FindField == "Kontakt")
                List = new ObservableCollection<SuppliersForView>(List.Where(item => item.Kontakt != null && item.Kontakt.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
