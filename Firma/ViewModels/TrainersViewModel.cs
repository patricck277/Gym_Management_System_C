using Firma.Helpers;
using Firma.Models.BusinessLogic;
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
    public class TrainersViewModel : WszystkieViewModels<TrainersForView>
    {

        #region  Constructor
        public TrainersViewModel()
        : base()
        {
            base.DisplayName = "Trainers";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<TrainersForView>
            (
                from trenerzy in gymEntities.Trenerzies select new TrainersForView

                {
                    IdTrener = trenerzy.IdTrener,
                    Imie = trenerzy.Imie,
                    Nazwisko = trenerzy.Nazwisko,
                    DataUrodzenia = trenerzy.DataUrodzenia,
                    Specializacja = trenerzy.Specializacja,
                    NumerTelefonu = trenerzy.NumerTelefonu,
                    AdresEmail = trenerzy.AdresEmail,
                    Aktywnosc = trenerzy.Aktywnosc,
                    KtoDodal = trenerzy.KtoDodalNavigation.Imie + " " + trenerzy.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = trenerzy.KiedyDodane,


                }
                
                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Imie", "Nazwisko", "Specializacja" };
        }
        public override void sort()
        {

            if (SortField == "Imie")
                List = new ObservableCollection<TrainersForView>(List.OrderBy(item => item.Imie));
            if (SortField == "Nazwisko")
                List = new ObservableCollection<TrainersForView>(List.OrderBy(item => item.Nazwisko));
            if (SortField == "Specializacja")
                List = new ObservableCollection<TrainersForView>(List.OrderBy(item => item.Specializacja));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Imie", "Nazwisko" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<TrainersForView>(List.Where(item => item.Imie
           != null && item.Imie.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<TrainersForView>(List.Where(item => item.Nazwisko != null && item.Nazwisko.StartsWith(FindTextBox)));
        }

        #endregion
    }
}
