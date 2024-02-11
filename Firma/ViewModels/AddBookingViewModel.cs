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
using GalaSoft.MvvmLight.Messaging;
using Firma.Models.EntitiesForView;

namespace Firma.ViewModels
{
    public class AddBookingViewModel : JedenViewModel<Rezerwacje>
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
        private BaseCommand _ShowAllClassesCommand;
        public ICommand ShowAllClassesCommand
        {
            get
            {
                if (_ShowAllClassesCommand == null)
                {
                    _ShowAllClassesCommand = new BaseCommand(() =>
                    Messenger.Default.Send("ClassesShow"));
                }
                return _ShowAllClassesCommand;
            }
        }
        #endregion


        #region  Constructor
        public AddBookingViewModel()
            : base("Add Booking")
        {
            item = new Rezerwacje();
            Messenger.Default.Register<ClientForView>(this, getCClient);
            Messenger.Default.Register<ClassesForView>(this, getCClasses);
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
       private void getCClasses(ClassesForView zajeciaofi)
        {
            IdZajecia = zajeciaofi.IdZajecia;
            ZajeciaofiNazwaZajec = zajeciaofi.NazwaZajec;
            ZajeciaofiDataRozpoczecia = zajeciaofi.DataRozpoczecia;
            ZajeciaofiGodzinaRozpoczecia = zajeciaofi.GodzinaRozpoczecia;
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
        public IQueryable<KeyAndValue> IdZajeciaComboBoxItems
        {
            get
            {
                return
                    (

                    from zajeciaOfi in gymEntities.ZajeciaOfis
                    select new KeyAndValue
                    {
                        Key = zajeciaOfi.IdZajecia,
                        Value = zajeciaOfi.NazwaZajec + " " + zajeciaOfi.DataRozpoczecia + " " + zajeciaOfi.GodzinaRozpoczecia
                    }
                    ).ToList().AsQueryable();
            }
        }
        public string? Potwierdzenie
        {
            get
            {
                return item.Potwierdzenie;
            }
            set
            {
                if (item.Potwierdzenie != value)
                {
                    item.Potwierdzenie = value;
                    base.OnPropertyChanged(() => Potwierdzenie);
                }
            }

        }
        public DateTime? Data
        {
            get
            {
                return item.Data;
            }
            set
            {
                if (item.Data != value)
                {
                    item.Data = value;
                    base.OnPropertyChanged(() => Data);
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

        public int? IdZajecia
        {
            get
            {
                return item.IdZajecia;
            }
            set
            {
                if (item.IdZajecia != value)
                {
                    item.IdZajecia = value;
                    base.OnPropertyChanged(() => IdZajecia);
                }
            }

        }


        private string? _ZajeciaofiNazwaZajec;
        public string? ZajeciaofiNazwaZajec
        {
            get
            {
                return _ZajeciaofiNazwaZajec;
            }
            set
            {
                if (_ZajeciaofiNazwaZajec != value)
                {
                    _ZajeciaofiNazwaZajec = value;
                    base.OnPropertyChanged(() => ZajeciaofiNazwaZajec);
                }
            }

        }

        private DateTime? _ZajeciaofiDataRozpoczecia;
        public DateTime? ZajeciaofiDataRozpoczecia
        {
            get
            {
                return _ZajeciaofiDataRozpoczecia;
            }
            set
            {
                if (_ZajeciaofiDataRozpoczecia != value)
                {
                    _ZajeciaofiDataRozpoczecia = value;
                    base.OnPropertyChanged(() => ZajeciaofiDataRozpoczecia);
                }
            }

        }

        private TimeSpan? _ZajeciaofiGodzinaRozpoczecia;
        public TimeSpan? ZajeciaofiGodzinaRozpoczecia

        {
            get
            {
                return _ZajeciaofiGodzinaRozpoczecia;
            }
            set
            {
                if (_ZajeciaofiGodzinaRozpoczecia != value)
                {
                    _ZajeciaofiGodzinaRozpoczecia = value;
                    base.OnPropertyChanged(() => ZajeciaofiGodzinaRozpoczecia);
                }
            }

        }

        #endregion



    }
}