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
    public class ClientViewModel:WszystkieViewModels<ClientForView>
    {
        #region Command
        private ClientForView _CClient;
        public ClientForView CClient
        {
            set
            {
                if (_CClient != value )
                {
                    _CClient = value;
                    Messenger.Default.Send(_CClient);

                    OnRequestClose();

                }
            }
            get
            {
                return _CClient;
            }
        }
        #endregion

        #region  Constructor
        public ClientViewModel()
        : base()
        {
            base.DisplayName = "Clients";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<ClientForView>
            (
                from klienci in gymEntities.Kliencis select new ClientForView

                {
                    IdKlienci = klienci.IdKlienci,
                    Imie = klienci.Imie,
                    Nazwisko = klienci.Nazwisko,
                    DataUrodzenia = klienci.DataUrodzenia,
                    Plec = klienci.Plec,
                    Adres = klienci.Adres,
                    NumerTelefonu = klienci.NumerTelefonu,
                    AdresEmail = klienci.AdresEmail,
                    DataZapisu = klienci.DataZapisu,
                    Aktywnosc = klienci.Aktywnosc,
                    KtoDodal = klienci.KtoDodalNavigation.IdPracownicy + " " + klienci.KtoDodalNavigation.Imie + " " + klienci.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = klienci.KiedyDodane,




                }
                
                
                
                
                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Imie", "Nazwisko", "Numer Telefonu" };
        }
        public override void sort()
        {

            if (SortField == "Imie")
                List = new ObservableCollection<ClientForView>(List.OrderBy(item => item.Imie));
            if (SortField == "Nazwisko")
                List = new ObservableCollection<ClientForView>(List.OrderBy(item => item.Nazwisko));
            if (SortField == "Numer Telefonu")
                List = new ObservableCollection<ClientForView>(List.OrderBy(item => item.NumerTelefonu));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Imie", "Nazwisko" };
        }
        public override void find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<ClientForView>(List.Where(item => item.Imie
           != null && item.Imie.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<ClientForView>(List.Where(item => item.Nazwisko != null && item.Nazwisko.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
