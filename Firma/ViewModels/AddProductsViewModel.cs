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
    public class AddProductsViewModel : JedenViewModel<Produkty>, IDataErrorInfo    
    {

        #region  Constructor
        public AddProductsViewModel()
            : base("Add New Products")
        {
            item = new Produkty();
        }
        #endregion  //  Constructor
        #region Data
        public string? NazwaProduktu
        {
            get
            {
                return item.NazwaProduktu;
            }
            set
            {

                if (item.NazwaProduktu != value)
                {
                    item.NazwaProduktu = value;
                    OnPropertyChanged(() => NazwaProduktu);
                }
            }
        }
        //
        public decimal? Cena
        {
            get
            {
                return item.Cena;
            }
            set
            {

                if (item.Cena != value)
                {
                    item.Cena = value;
                    OnPropertyChanged(() => Cena);
                }
            }
        }
        //
        public string? IloscDostepna
        {
            get
            {
                return item.IloscDostepna;
            }
            set
            {

                if (item.IloscDostepna != value)
                {
                    item.IloscDostepna = value;
                    OnPropertyChanged(() => IloscDostepna);
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
                if (name == "Cena")
                {
                    komunikat = BiznesValidator.SprawdzCenaPrzedzial(this.Cena);
                }
                if (name == "NazwaProduktu")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.NazwaProduktu);
                }
                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["NazwaProduktu"] == null && this["Cena"] == null)
                return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }

        #endregion
    }
}