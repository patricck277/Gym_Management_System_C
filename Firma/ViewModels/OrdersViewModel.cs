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
    public class OrdersViewModel : WszystkieViewModels<OrdersForView>
    {

        #region  Constructor
        public OrdersViewModel()
        : base()
        {
            base.DisplayName = "Orders";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<OrdersForView>
            (
                from zamowienium in gymEntities.Zamowienia select new OrdersForView

                {
                    IdZamowienia = zamowienium.IdZamowienia,
                    DostawcaNazwaDostawcy = zamowienium.IdDostawcaNavigation.NazwaDostawcy,
                    DostawcaAdres = zamowienium.IdDostawcaNavigation.Adres,
                    DostawcaKontkat = zamowienium.IdDostawcaNavigation.Kontakt,
                    DataZamowienia = zamowienium.DataZamowienia,
                    Status = zamowienium.Status,
                    Aktywnosc = zamowienium.Aktywnosc,
                    KtoDodal = zamowienium.KtoDodalNavigation.IdPracownicy + " " + zamowienium.KtoDodalNavigation.Imie + " " + zamowienium.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = zamowienium.KiedyDodane
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
                List = new ObservableCollection<OrdersForView>(List.OrderBy(item => item.DostawcaNazwaDostawcy));


        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa Dostawcy" };
        }
        public override void find()
        {
            if (FindField == "Nazwa Dostawcy")
                List = new ObservableCollection<OrdersForView>(List.Where(item => item.DostawcaNazwaDostawcy
           != null && item.DostawcaNazwaDostawcy.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
