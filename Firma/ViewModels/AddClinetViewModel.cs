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
    public class AddClientViewModel:JedenViewModel<Klienci>, IDataErrorInfo 
    {
       
        #region  Constructor
        public AddClientViewModel()
            : base("Add Client")
        {
            item = new Klienci();
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
        public string? Plec
        {
            get
            {
                return item.Plec;
            }
            set
            {

                if (item.Plec != value)
                {
                    item.Plec = value;
                    OnPropertyChanged(() => Plec);
                }
            }
        }
        //
        public string? Adres
        {
            get
            {
                return item.Adres;
            }
            set
            {

                if (item.Adres != value)
                {
                    item.Adres = value;
                    OnPropertyChanged(() => Adres);
                }
            }
        }
        //
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
        //
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
        public DateTime? DataZapisu

        {
            get
            {
                return item.DataZapisu;
            }
            set
            {

                if (item.DataZapisu != value)
                {
                    item.DataZapisu = value;
                    OnPropertyChanged(() => DataZapisu);
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