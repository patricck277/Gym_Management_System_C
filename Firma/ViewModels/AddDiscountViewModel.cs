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
    public class AddDiscountViewModel : JedenViewModel<Promocje>, IDataErrorInfo    
    {

        #region  Constructor
        public AddDiscountViewModel()
            : base("Add Discount")
        {
            item = new Promocje();
        }
        #endregion  //  Constructor

        #region Data
        public string? NazwaPromocji
        {
            get
            {
                return item.NazwaPromocji;
            }
            set
            {

                if (item.NazwaPromocji != value)
                {
                    item.NazwaPromocji = value;
                    OnPropertyChanged(() => NazwaPromocji);
                }
            }
        }
        //
        public string? OpisPromocji
        {
            get
            {
                return item.OpisPromocji;
            }
            set
            {

                if (item.OpisPromocji != value)
                {
                    item.OpisPromocji = value;
                    OnPropertyChanged(() => OpisPromocji);
                }
            }
        }
        //
        public DateTime? DataRozpoczecia
        {
            get
            {
                return item.DataRozpoczecia;
            }
            set
            {

                if (item.DataRozpoczecia != value)
                {
                    item.DataRozpoczecia = value;
                    OnPropertyChanged(() => DataRozpoczecia);
                }
            }
        }
        //
        public DateTime? DataZakonczenia

        {
            get
            {
                return item.DataZakonczenia;
            }
            set
            {

                if (item.DataZakonczenia != value)
                {
                    item.DataZakonczenia = value;
                    OnPropertyChanged(() => DataZakonczenia);
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

                if (name == "NazwaPromocji")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.NazwaPromocji);
                }
                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["NazwaPromocji"] == null )
                return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }

        #endregion

    }
}