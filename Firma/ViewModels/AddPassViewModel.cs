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
using System.ComponentModel;
using Firma.Models.Validatory;

namespace Firma.ViewModels
{
    public class AddPassViewModel : JedenViewModel<Karnety>, IDataErrorInfo
    {

        #region  Constructor
        public AddPassViewModel()
            : base("Add New Pass")
        {
            item = new Karnety();
        }
        #endregion  //  Constructor

        #region Data
        public string? NazwaKarnetu
        {
            get
            {
                return item.NazwaKarnetu;
            }
            set
            {

                if (item.NazwaKarnetu != value)
                {
                    item.NazwaKarnetu = value;
                    OnPropertyChanged(() => NazwaKarnetu);
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
        public DateTime? OkresWaznosci
        {
            get
            {
                return item.OkresWaznosci;
            }
            set
            {

                if (item.OkresWaznosci != value)
                {
                    item.OkresWaznosci = value;
                    OnPropertyChanged(() => OkresWaznosci);
                }
            }
        }
        //
        public string? RodzajKarnetu
        {
            get
            {
                return item.RodzajKarnetu;
            }
            set
            {

                if (item.RodzajKarnetu != value)
                {
                    item.RodzajKarnetu = value;
                    OnPropertyChanged(() => RodzajKarnetu);
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
                if (name == "NazwaKarnetu")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaOdDuzej(this.NazwaKarnetu);
                }
                return komunikat;
            }
        }
        //sprawdzamy tylko nazwe i cena
        public override bool IsValid()
        {
            if (this["NazwaKarnetu"] == null && this["Cena"] == null)
                    return true; //zwracane jest true ejezeli nie ma bledu tu i tu
            return false;
        }
        
        #endregion
    }
}