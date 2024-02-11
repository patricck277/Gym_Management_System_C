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
    public class AddEquipmentViewModel : JedenViewModel<Sprzet>, IDataErrorInfo 
    {

        #region  Constructor
        public AddEquipmentViewModel()
            : base("Add New Equipment")
        {
            item = new Sprzet();
        }
        #endregion  //  Constructor

        #region Data
        public string? NazwaSprzetu
        {
            get
            {
                return item.NazwaSprzetu;
            }
            set
            {

                if (item.NazwaSprzetu != value)
                {
                    item.NazwaSprzetu = value;
                    OnPropertyChanged(() => NazwaSprzetu);
                }
            }
        }
        //
        public string? Producent
        {
            get
            {
                return item.Producent;
            }
            set
            {

                if (item.Producent != value)
                {
                    item.Producent = value;
                    OnPropertyChanged(() => Producent);
                }
            }
        }
        //
        public DateTime? RokProdukcji
        {
            get
            {
                return item.RokProdukcji;
            }
            set
            {

                if (item.RokProdukcji != value)
                {
                    item.RokProdukcji = value;
                    OnPropertyChanged(() => RokProdukcji);
                }
            }
        }
        //
        public int? IloscDostepnych
        {
            get
            {
                return item.IloscDostepnych;
            }
            set
            {

                if (item.IloscDostepnych != value)
                {
                    item.IloscDostepnych = value;
                    OnPropertyChanged(() => IloscDostepnych);
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
                if (name == "IloscDostepnych")
                {
                    komunikat = BiznesValidator.SprawdzCenaPrzedzial(this.IloscDostepnych);
                }
                if (name == "NazwaSprzetu")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.NazwaSprzetu);
                }
                if (name == "Producent")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.Producent);
                }
                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["NazwaSprzetu"] == null && this["Producent"] == null)
                if (this["IloscDostepnych"] == null)
                    return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }

        #endregion
    }
}