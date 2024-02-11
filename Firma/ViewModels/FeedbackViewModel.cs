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
    public class FeedbackViewModel : WszystkieViewModels<FeedbackForView>
    {

        #region  Constructor
        public FeedbackViewModel()
        : base()
        {
            base.DisplayName = "Feedback";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<FeedbackForView>
            (
                from ocenytrenerow in gymEntities.OcenyTrenerows select new FeedbackForView


                {
                    IdOcenyTrenerow = ocenytrenerow.IdOcenyTrenerow,
                    KlientImie = ocenytrenerow.IdKlientNavigation.Imie + " " + ocenytrenerow.IdKlientNavigation.Nazwisko + " " + ocenytrenerow.IdKlientNavigation.DataUrodzenia,
                    TrenerImie = ocenytrenerow.IdTrenerNavigation.Imie + " " + ocenytrenerow.IdTrenerNavigation.Nazwisko + " " + ocenytrenerow.IdTrenerNavigation.Specializacja,          
                    Ocena = ocenytrenerow.Ocena,
                    Komentarz = ocenytrenerow.Komentarz,
                    DataOceny = ocenytrenerow.DataOceny,
                    Aktywnosc = ocenytrenerow.Aktywnosc,
                    KtoDodal = ocenytrenerow.KtoDodalNavigation.IdPracownicy + " " + ocenytrenerow.KtoDodalNavigation.Imie + " " + ocenytrenerow.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = ocenytrenerow.KiedyDodane

                }
                
                
                
                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Klient Imie", "Trener Imie" };
        }
        public override void sort()
        {

            if (SortField == "Klient Imie")
                List = new ObservableCollection<FeedbackForView>(List.OrderBy(item => item.KlientImie));
            if (SortField == "Klient Imie")
                List = new ObservableCollection<FeedbackForView>(List.OrderBy(item => item.TrenerImie));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Klient Imie", "Trener Imie" };
        }
        public override void find()
        {
            if (FindField == "Klient Imie")
                List = new ObservableCollection<FeedbackForView>(List.Where(item => item.KlientImie
           != null && item.KlientImie.StartsWith(FindTextBox)));
            if (FindField == "Trener Imie")
                List = new ObservableCollection<FeedbackForView>(List.Where(item => item.TrenerImie != null && item.TrenerImie.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
