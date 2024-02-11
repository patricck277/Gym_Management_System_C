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

namespace Firma.ViewModels
{
    public class AddOrdersViewModel : JedenViewModel<Zamowienium>
    {

        #region  Constructor
        public AddOrdersViewModel()
            : base("Add New Orders")
        {
            item = new Zamowienium();
        }
        #endregion  //  Constructor
        #region Data
        public int? IdDostawcy
        {
            get
            {
                return item.IdDostawca;
            }
            set
            {
                if (item.IdDostawca != value)
                {
                    item.IdDostawca = value;
                    base.OnPropertyChanged(() => IdDostawcy);
                }
            }

        }
        //
        public DateTime? DataZamowienia
        {
            get
            {
                return item.DataZamowienia;
            }
            set
            {

                if (item.DataZamowienia != value)
                {
                    item.DataZamowienia = value;
                    OnPropertyChanged(() => DataZamowienia);
                }
            }
        }
        //
        public string? Status
        {
            get
            {
                return item.Status;
            }
            set
            {

                if (item.Status != value)
                {
                    item.Status = value;
                    OnPropertyChanged(() => Status);
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
        public IQueryable<Dostawcy> IdDostawcyComboBoxItems
        {
            get
            {
                return
                    (

                    from dostawcy in gymEntities.Dostawcies 
                    select dostawcy
                    ).ToList().AsQueryable();
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
        #endregion
    }
}