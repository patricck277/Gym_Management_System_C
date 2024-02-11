using Firma.Helpers;
using Firma.Models.Context;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class PayViewModel : WszystkieViewModels<PayForView>
    {
        
        #region  Constructor
        public PayViewModel()
        : base()
        {
            base.DisplayName = "Pay";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<PayForView>
            (from platnosci in gymEntities.Platnoscis select new PayForView

            {
                IdPlatnosci = platnosci.IdPlatnosci,
                KlientImie = platnosci.IdKlientNavigation.Imie,
                KlientNazwisko = platnosci.IdKlientNavigation.Nazwisko,
                KlientDataUrodzenia = platnosci.IdKlientNavigation.DataUrodzenia,
                KarnetNazwaKarnetu = platnosci.IdKarnetNavigation.NazwaKarnetu,
                KarnetRodzajKarnetu = platnosci.IdKarnetNavigation.RodzajKarnetu,
                KarnetOkresWaznosci = platnosci.IdKarnetNavigation.OkresWaznosci,
                DataPlatnosci = platnosci.DataPlatnosci,
                Kwota = platnosci.Kwota,
                Aktywnosc = platnosci.Aktywnosc,
                KiedyDodane = platnosci.KiedyDodane,
                KtoDodal = platnosci.KtoDodalNavigation.IdPracownicy + " " + platnosci.KtoDodalNavigation.Imie + " " + platnosci.KtoDodalNavigation.Nazwisko


            }





             );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Klient Imie", "Nazwa Karnetu", "Kwota" };
        }
        public override void sort()
        {

            if (SortField == "Klient Imie")
                List = new ObservableCollection<PayForView>(List.OrderBy(item => item.KlientImie));
            if (SortField == "Nazwa Karnetu")
                List = new ObservableCollection<PayForView>(List.OrderBy(item => item.KarnetNazwaKarnetu));
            if (SortField == "Kwota")
                List = new ObservableCollection<PayForView>(List.OrderBy(item => item.Kwota));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Klient Imie", "Nazwa Karnetu" };
        }
        public override void find()
        {
            if (FindField == "Klient Imie")
                List = new ObservableCollection<PayForView>(List.Where(item => item.KlientImie
           != null && item.KlientImie.StartsWith(FindTextBox)));
            if (FindField == "Nazwa Karnetu")
                List = new ObservableCollection<PayForView>(List.Where(item => item.KarnetNazwaKarnetu != null && item.KarnetNazwaKarnetu.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
