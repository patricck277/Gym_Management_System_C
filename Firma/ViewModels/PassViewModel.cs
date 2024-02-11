using Firma.Models.Context;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Firma.ViewModels
{
    public class PassViewModel : WszystkieViewModels<PassForView>
    {

        #region  Constructor
        public PassViewModel()
        : base()
        {
            base.DisplayName = "Pass";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<PassForView>
            (from karnety in gymEntities.Karneties select new PassForView

            {
                IdKarnety = karnety.IdKarnety,
                NazwaKarnetu = karnety.NazwaKarnetu,
                Cena = karnety.Cena,
                OkresWaznosci = karnety.OkresWaznosci,
                RodzajKarnetu = karnety.RodzajKarnetu,
                Aktywnosc = karnety.Aktywnosc,
                KtoDodal = karnety.KtoDodalNavigation.IdPracownicy + " " + karnety.KtoDodalNavigation.Imie + " " + karnety.KtoDodalNavigation.Nazwisko,
                KiedyDodane = karnety.KiedyDodane


            }
             
             
             );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa Karnetu", "Rodzaj Karnetu" };
        }
        public override void sort()
        {

            if (SortField == "Nazwa Karnetu")
                List = new ObservableCollection<PassForView>(List.OrderBy(item => item.NazwaKarnetu));
            if (SortField == "Rodzaj Karnetu")
                List = new ObservableCollection<PassForView>(List.OrderBy(item => item.RodzajKarnetu));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "NazwaKarnetu", "Cena" };
        }
        public override void find()
        {
            if (FindField == "Nazwa Karnetu")
                List = new ObservableCollection<PassForView>(List.Where(item => item.NazwaKarnetu
           != null && item.NazwaKarnetu.StartsWith(FindTextBox)));
            if (FindField == "Rodzaj Karnetu")
                List = new ObservableCollection<PassForView>(List.Where(item => item.RodzajKarnetu != null && item.RodzajKarnetu.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
