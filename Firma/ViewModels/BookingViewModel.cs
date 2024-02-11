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
    public class BookingViewModel : WszystkieViewModels<BookingForView>
    {


        #region  Constructor
        public BookingViewModel()
        : base()
        {
            base.DisplayName = "Booking";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<BookingForView>
            (
                from rezerwacje in gymEntities.Rezerwacjes select new BookingForView

                {
                    IdRezerwacje = rezerwacje.IdRezerwacje,
                    KlientImie = rezerwacje.IdKlientNavigation.Imie,
                    KlientNazwisko = rezerwacje.IdKlientNavigation.Nazwisko,
                    KlientDataUrodzenia = rezerwacje.IdKlientNavigation.DataUrodzenia,
                    ZajeciaOfiNazwaZajec = rezerwacje.IdZajeciaNavigation.NazwaZajec,
                    ZajeciaOfiDataRozpoczecia = rezerwacje.IdZajeciaNavigation.DataRozpoczecia,
                    ZajeciaOfiGodzinaRozpoczecia = rezerwacje.IdZajeciaNavigation.GodzinaRozpoczecia,
                    Data = rezerwacje.Data,
                    Potwierdzenie = rezerwacje.Potwierdzenie,
                    Aktywnosc = rezerwacje.Aktywnosc,
                    KtoDodal = rezerwacje.KtoDodalNavigation.IdPracownicy + " " + rezerwacje.KtoDodalNavigation.Imie + " " + rezerwacje.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = rezerwacje.KiedyDodane,

                }
            
                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Imie", "Nazwisko", "Zajecia" };
        }
        public override void sort()
        {

            if (SortField == "Imie")
                List = new ObservableCollection<BookingForView>(List.OrderBy(item => item.KlientImie));
            if (SortField == "Nazwisko")
                List = new ObservableCollection<BookingForView>(List.OrderBy(item => item.KlientNazwisko));
            if (SortField == "Zajecia")
                List = new ObservableCollection<BookingForView>(List.OrderBy(item => item.ZajeciaOfiNazwaZajec));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Imie", "Nazwisko" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<BookingForView>(List.Where(item => item.KlientImie
           != null && item.KlientImie.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<BookingForView>(List.Where(item => item.KlientNazwisko != null && item.KlientNazwisko.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
