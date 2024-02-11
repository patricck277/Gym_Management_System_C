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
    public class AttendanceViewModel : WszystkieViewModels<AttendanceForView>
    {
        #region  Constructor
        public AttendanceViewModel()
        : base()
        {
            base.DisplayName = "Attendance";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<AttendanceForView>
            (
                from obecnosc in gymEntities.Obecnoscs select new AttendanceForView
                {
                    IdObecnosc = obecnosc.IdObecnosc,
                    KlientImie = obecnosc.IdKlientNavigation.Imie,
                    KlientNazwisko = obecnosc.IdKlientNavigation.Nazwisko,
                    KlientDataUrodzenia = obecnosc.IdKlientNavigation.DataUrodzenia,
                    ZajeciaOfiNazwaZajec = obecnosc.IdZajeciaNavigation.NazwaZajec,
                    ZajeciaOfiDataRozpoczecia = obecnosc.IdZajeciaNavigation.DataRozpoczecia,
                    ZajeciaOfiGodzinaRozpoczecia = obecnosc.IdZajeciaNavigation.GodzinaRozpoczecia,
                    Data = obecnosc.Data,
                    Obecnosc1 = obecnosc.Obecnosc1,
                    Aktywnosc = obecnosc.Aktywnosc,
                    KtoDodal = obecnosc.KtoDodalNavigation.IdPracownicy + " "+ obecnosc.KtoDodalNavigation.Imie+ " " + obecnosc.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = obecnosc.KiedyDodane,

                }

                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "KlientImie", "KlientNazwisko", "ZajeciaOfiNazwaZajec" };
        }
        public override void sort()
        {

            if (SortField == "Klient Imie")
                List = new ObservableCollection<AttendanceForView>(List.OrderBy(item => item.KlientImie));
            if (SortField == "Klient Nazwisko")
                List = new ObservableCollection<AttendanceForView>(List.OrderBy(item => item.KlientNazwisko));
            if (SortField == "ZajeciaOfiNazwaZajec")
                List = new ObservableCollection<AttendanceForView>(List.OrderBy(item => item.ZajeciaOfiNazwaZajec));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Imie", "Nazwisko" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<AttendanceForView>(List.Where(item => item.KlientImie
           != null && item.KlientImie.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<AttendanceForView>(List.Where(item => item.KlientNazwisko != null && item.KlientNazwisko.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
