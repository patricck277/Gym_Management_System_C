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
    public class MessageViewModel : WszystkieViewModels<MessageForView>
    {

        #region  Constructor
        public MessageViewModel()
        : base()
        {
            base.DisplayName = "Message";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<MessageForView>
            (
                from powiadomienium in gymEntities.Powiadomienia select new MessageForView

                {
                    IdPowiadomienia = powiadomienium.IdPowiadomienia,
                    KlientImie = powiadomienium.IdKlientNavigation.Imie + " " + powiadomienium.IdKlientNavigation.Nazwisko + " " + powiadomienium.IdKlientNavigation.DataUrodzenia,
                    TrenerImie = powiadomienium.IdTrenerNavigation.Imie + " " + powiadomienium.IdTrenerNavigation.Nazwisko + " " + powiadomienium.IdTrenerNavigation.Specializacja,
                    TrescPowiadomienia = powiadomienium.TrescPowiadomienia,
                    DataWyslania = powiadomienium.DataWyslania,
                    Aktywnosc = powiadomienium.Aktywnosc,
                    KiedyDodane = powiadomienium.KiedyDodane,
                    KtoDodal = powiadomienium.KtoDodalNavigation.IdPracownicy + " " + powiadomienium.KtoDodalNavigation.Imie + " " + powiadomienium.KtoDodalNavigation.Nazwisko

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
                List = new ObservableCollection<MessageForView>(List.OrderBy(item => item.KlientImie));
            if (SortField == "Trener Imie")
                List = new ObservableCollection<MessageForView>(List.OrderBy(item => item.TrenerImie));


        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Klient Imie", "Trener Imie" };
        }
        public override void find()
        {
            if (FindField == "Klient Imie")
                List = new ObservableCollection<MessageForView>(List.Where(item => item.KlientImie
           != null && item.KlientImie.StartsWith(FindTextBox)));
            if (FindField == "Trener Imie")
                List = new ObservableCollection<MessageForView>(List.Where(item => item.TrenerImie != null && item.TrenerImie.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
