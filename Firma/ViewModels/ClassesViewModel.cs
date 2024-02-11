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
    public class ClassesViewModel:WszystkieViewModels<ClassesForView>
    {

        #region Command
        private ClassesForView _CClasses;
        public ClassesForView CClasses
        {
            set
            {
                if (_CClasses != value)
                {
                    _CClasses = value;
                    Messenger.Default.Send(_CClasses);

                    OnRequestClose();

                }
            }
            get
            {
                return _CClasses;
            }
        }
        #endregion

        #region  Constructor
        public ClassesViewModel()
        : base()
        {
            base.DisplayName = "Classes";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<ClassesForView>
            (
                from zajeciaofi in gymEntities.ZajeciaOfis select new ClassesForView

                {
                   IdZajecia = zajeciaofi.IdZajecia,
                   NazwaZajec = zajeciaofi.NazwaZajec,
                   TrenerImie = zajeciaofi.IdTreneraNavigation.Imie,
                    TrenerNazwisko = zajeciaofi.IdTreneraNavigation.Nazwisko,
                    TrenerSpecializacja = zajeciaofi.IdTreneraNavigation.Specializacja,
                    DataRozpoczecia = zajeciaofi.DataRozpoczecia,
                    GodzinaRozpoczecia = zajeciaofi.GodzinaRozpoczecia,
                    GodzinaZakonczenia = zajeciaofi.GodzinaZakonczenia,
                    Aktywnosc = zajeciaofi.Aktywnosc,
                    KtoDodal = zajeciaofi.KtoDodalNavigation.IdPracownicy + " " + zajeciaofi.KtoDodalNavigation.Imie + " " + zajeciaofi.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = zajeciaofi.KiedyDodane,


                }





                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa zajec", "Imie trenera" };
        }
        public override void sort()
        {

            if (SortField == "Nazwa zajec")
                List = new ObservableCollection<ClassesForView>(List.OrderBy(item => item.NazwaZajec));
            if (SortField == "Imie trenera")
                List = new ObservableCollection<ClassesForView>(List.OrderBy(item => item.TrenerImie));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa zajec", "Imie trenera" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<ClassesForView>(List.Where(item => item.NazwaZajec
           != null && item.NazwaZajec.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<ClassesForView>(List.Where(item => item.TrenerImie != null && item.TrenerImie.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
