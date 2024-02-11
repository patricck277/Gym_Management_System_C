using Firma.Helpers;
using Firma.Models.Context;
using Firma.Models.Entities;
using System;
using Firma.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Firma.Models.EntitiesForView;
using GalaSoft.MvvmLight.Messaging;
using System.ComponentModel;
using Firma.Models.Validatory;

namespace Firma.ViewModels
{
    public class AddPayViewModel : JedenViewModel<Platnosci>, IDataErrorInfo    
    {
        #region Command
        private BaseCommand _ShowAllClientCommand;
        public ICommand ShowAllClientCommand
        {
            get
            {
                if (_ShowAllClientCommand == null)
                {
                    _ShowAllClientCommand = new BaseCommand(() =>
                    Messenger.Default.Send("ClientShow"));
                }
                return _ShowAllClientCommand;
            }
        }
        #endregion
        #region  Constructor
        public AddPayViewModel()
            : base("Add New Pay")
        {
            item = new Platnosci();
            Messenger.Default.Register<ClientForView>(this, getCClient);
        }
        #endregion  //  Constructor
        #region Helper
        private void getCClient(ClientForView klenci)
        {
            IdKlient = klenci.IdKlienci;
            KlientImie = klenci.Imie;
            KlientNazwisko = klenci.Nazwisko;
            KlientDataUrodzenia = klenci.DataUrodzenia;
        }
        #endregion
        #region Fields

        public int? IdKlient
        {
            get
            {
                return item.IdKlient;
            }
            set
            {
                if (item.IdKlient != value)
                {
                    item.IdKlient = value;
                    base.OnPropertyChanged(() => IdKlient);
                }
            }

        }

        private string? _KlientImie;
        public string? KlientImie
        {
            get
            {
                return _KlientImie;
            }
            set
            {
                if (_KlientImie != value)
                {
                    _KlientImie = value;
                    base.OnPropertyChanged(() => KlientImie);
                }
            }

        }

        private string? _KlientNazwisko;
        public string? KlientNazwisko
        {
            get
            {
                return _KlientNazwisko;
            }
            set
            {
                if (_KlientNazwisko != value)
                {
                    _KlientNazwisko = value;
                    base.OnPropertyChanged(() => KlientNazwisko);
                }
            }

        }

        private DateTime? _KlientDataUrodzenia;
        public DateTime? KlientDataUrodzenia

        {
            get
            {
                return _KlientDataUrodzenia;
            }
            set
            {
                if (_KlientDataUrodzenia != value)
                {
                    _KlientDataUrodzenia = value;
                    base.OnPropertyChanged(() => KlientDataUrodzenia);
                }
            }

        }

        public int? IdKarnety
        {
            get
            {
                return item.IdKarnet;
            }
            set
            {
                if (item.IdKarnet != value)
                {
                    item.IdKarnet = value;
                    base.OnPropertyChanged(() => IdKarnety);
                }
            }

        }
        public DateTime? DataPlatnosci
        {
            get
            {
                return item.DataPlatnosci;
            }
            set
            {
                if (item.DataPlatnosci != value)
                {
                    item.DataPlatnosci = value;
                    base.OnPropertyChanged(() => DataPlatnosci);
                }
            }

        }
        public decimal? Kwota
        {
            get
            {
                return item.Kwota;
            }
            set
            {
                if (item.Kwota != value)
                {
                    item.Kwota = value;
                    base.OnPropertyChanged(() => Kwota);
                }
            }

        }
        public string? Aktywnosc
        {
            get
            {
                return item.Aktywnosc;
            }
            set
            {
                if (item.Aktywnosc != value)
                {
                    item.Aktywnosc = value;
                    base.OnPropertyChanged(() => Aktywnosc);
                }
            }

        }
        public int? KtoDodal
        {
            get
            {
                return item.KtoDodal;
            }
            set
            {
                if (item.KtoDodal != value)
                {
                    item.KtoDodal = value;
                    base.OnPropertyChanged(() => KtoDodal);
                }
            }

        }
        public DateTime? KiedyDodane
        {
            get
            {
                return item.KiedyDodane;
            }
            set
            {
                if (item.KiedyDodane != value)
                {
                    item.KiedyDodane = value;
                    base.OnPropertyChanged(() => KiedyDodane);
                }
            }

        }

        public IQueryable<KeyAndValue> IdKlientComboBoxItems
        {
            get
            {
                return
                    (

                    from klienci in gymEntities.Kliencis
                    select new KeyAndValue
                    {
                        Key = klienci.IdKlienci,
                        Value = klienci.Imie + " " + klienci.Nazwisko + " " + klienci.DataUrodzenia
                    }
                    ).ToList().AsQueryable();
            }
        }

        public IQueryable<Karnety> IdKarnetyComboBoxItems
        {
            get
            {
                return
                    (

                    from karnety in gymEntities.Karneties   
                    select karnety
                    ).ToList().AsQueryable();
            }
        }

        public IQueryable<Pracownicy> IdPracownicyComboBoxItems
        {
            get
            {
                return
                    (

                    from pracownicy in gymEntities.Pracownicies
                    select pracownicy
                    ).ToList().AsQueryable();
            }
        }


        #endregion
        #region Validation
        public string Error
        {
            get
            {
                return null;
            }
        }
        public string this[string name]
        {
            get
            {
                string komunikat = null;
                if (name == "Kwota")
                {
                    komunikat = BiznesValidator.SprawdzCenaPrzedzial(this.Kwota);
                }

                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["Kwota"] == null)
                return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }

        #endregion
    }
}