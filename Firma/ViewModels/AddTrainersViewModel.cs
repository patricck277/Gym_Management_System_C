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
using Firma.Models.Validatory;
using System.ComponentModel;

namespace Firma.ViewModels
{
    public class AddTrainersViewModel : JedenViewModel<Trenerzy>, IDataErrorInfo    
    {

        #region  Constructor
        public AddTrainersViewModel()
            : base("Add New Trainer")
        {
            item = new Trenerzy();
        }
        #endregion  //  Constructor
        #region Data
        public string? Imie
        {
            get
            {
                return item.Imie;
            }
            set
            {

                if (item.Imie != value)
                {
                    item.Imie = value;
                    OnPropertyChanged(() => Imie);
                }
            }
        }
        //
        public string? Nazwisko
        {
            get
            {
                return item.Nazwisko;
            }
            set
            {

                if (item.Nazwisko != value)
                {
                    item.Nazwisko = value;
                    OnPropertyChanged(() => Nazwisko);
                }
            }
        }
        //
        public DateTime? DataUrodzenia
        {
            get
            {
                return item.DataUrodzenia;
            }
            set
            {

                if (item.DataUrodzenia != value)
                {
                    item.DataUrodzenia = value;
                    OnPropertyChanged(() => DataUrodzenia);
                }
            }
        }
        //
        public string? Specializacja
        {
            get
            {
                return item.Specializacja;
            }
            set
            {

                if (item.Specializacja != value)
                {
                    item.Specializacja = value;
                    OnPropertyChanged(() => Specializacja);
                }
            }
        }
        public string? NumerTelefonu
        {
            get
            {
                return item.NumerTelefonu;
            }
            set
            {

                if (item.NumerTelefonu != value)
                {
                    item.NumerTelefonu = value;
                    OnPropertyChanged(() => NumerTelefonu);
                }
            }
        }
        public string? AdresEmail
        {
            get
            {
                return item.AdresEmail;
            }
            set
            {

                if (item.AdresEmail != value)
                {
                    item.AdresEmail = value;
                    OnPropertyChanged(() => AdresEmail);
                }
            }
        }
        //
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
        //
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
        //
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
        //
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
                if (name == "Imie")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.Imie);
                }
                if (name == "Nazwisko")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.Nazwisko);
                }
                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["Imie"] == null && this["Nazwisko"] == null)
                return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }

        #endregion
    }
}