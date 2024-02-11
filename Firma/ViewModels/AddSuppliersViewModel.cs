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
    public class AddSuppliersViewModel : JedenViewModel<Dostawcy>, IDataErrorInfo
    {

        #region  Constructor
        public AddSuppliersViewModel()
            : base("Add New Suppliers")
        {
            item = new Dostawcy();
        }
        #endregion  //  Constructor
        #region Data
        public string? NazwaDostawcy
        {
            get
            {
                return item.NazwaDostawcy;
            }
            set
            {

                if (item.NazwaDostawcy != value)
                {
                    item.NazwaDostawcy = value;
                    OnPropertyChanged(() => NazwaDostawcy);
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
        public string? Kontakt
        {
            get
            {
                return item.Kontakt;
            }
            set
            {

                if (item.Kontakt != value)
                {
                    item.Kontakt = value;
                    OnPropertyChanged(() => Kontakt);
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
                if (name == "NazwaDostawcy")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.NazwaDostawcy);
                }
                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["NazwaDostawcy"] == null )
                return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }

        #endregion
    }
}