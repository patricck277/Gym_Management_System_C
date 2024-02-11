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
    public class EmployeesViewModel : WszystkieViewModels<EmployeesForView>
    {

        #region  Constructor
        public EmployeesViewModel()
        : base()
        {
            base.DisplayName = "Employees";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<EmployeesForView>
            (
                from pracownicy in gymEntities.Pracownicies select new EmployeesForView

                {
                    IdPracownicy = pracownicy.IdPracownicy,
                    Imie = pracownicy.Imie,
                    Nazwisko = pracownicy.Nazwisko,
                    Stanowisko = pracownicy.Stanowisko,
                    DataZatrudnienia = pracownicy.DataZatrudnienia,
                    Pensja = pracownicy.Pensja,
                    Aktywnosc = pracownicy.Aktywnosc,
                    KtoDodal = pracownicy.KtoDodalNavigation.IdPracownicy + " " + pracownicy.KtoDodalNavigation.Imie + " " + pracownicy.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = pracownicy.KiedyDodane


                }

                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Imie", "Nazwisko", "Stanowisko" };
        }
        public override void sort()
        {

            if (SortField == "Imie")
                List = new ObservableCollection<EmployeesForView>(List.OrderBy(item => item.Imie));
            if (SortField == "Nazwisko")
                List = new ObservableCollection<EmployeesForView>(List.OrderBy(item => item.Nazwisko));
            if (SortField == "Stanowisko")
                List = new ObservableCollection<EmployeesForView>(List.OrderBy(item => item.Stanowisko));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Imie", "Nazwisko" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<EmployeesForView>(List.Where(item => item.Imie
           != null && item.Imie.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<EmployeesForView>(List.Where(item => item.Nazwisko != null && item.Nazwisko.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
