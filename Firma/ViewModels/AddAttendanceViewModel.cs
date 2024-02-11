using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class AddAttendanceViewModel : JedenViewModel<Obecnosc>
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


        public AddAttendanceViewModel()
            : base("Add New Attendance")
        {
            item = new Obecnosc();
            Messenger.Default.Register<ClientForView>(this, getCClient);
        }

        #endregion

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
        public string? Obecnosc1
        {
            get
            {
                return item.Obecnosc1;
            }
            set
            {
                if (item.Obecnosc1 != value)
                {
                    item.Obecnosc1 = value;
                    base.OnPropertyChanged(() => Obecnosc1);
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

        public IQueryable<ZajeciaOfi> IdZajeciaComboBoxItems
        {
            get
            {
                return
                    (

                    from zajeciaOfi in gymEntities.ZajeciaOfis
                    select zajeciaOfi
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
    }

}


