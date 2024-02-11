using Firma.Helpers;
using Firma.Models.BusinessLogic;
using Firma.Models.Context;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class RaportWynikuViewModel : WorkspaceViewModel
    {
        #region DB
        //polaczenie  z  baza  danych
        protected readonly GymEntities gymEntities;
        #endregion

        #region  Fields and Properties

        private DateTime _DataOd;
        public DateTime DataOd
        {
            get
            {
                return _DataOd;
            }
            set
            {
                if (value != _DataOd)
                {
                    _DataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }
        private DateTime _DataDo;
        public DateTime DataDo
        {
            get
            {
                return _DataDo;
            }
            set
            {
                if (value != _DataDo)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }
        private int _IdKlienci;
        public int IdKlienci
        {
            get
            {
                return _IdKlienci;
            }
            set
            {
                if (value != _IdKlienci)
                {
                    _IdKlienci = value;
                    OnPropertyChanged(() => IdKlienci);
                }
            }
        }
        private decimal? _Utarg;
        public decimal? Utarg
        {
            get
            {
                return _Utarg;
            }
            set
            {
                if (value != _Utarg)
                {
                    _Utarg = value;
                    OnPropertyChanged(() => Utarg);
                }
            }
        }
        public IQueryable<KeyAndValue> WynikComboBoxItems
        {
            get
            {
                return new ClientC(gymEntities).GetClientKeyAndValueItems();
            }
        }

        #endregion
        #region  Constructor
        public RaportWynikuViewModel()
        {
            base.DisplayName = "Client Report";
            this.gymEntities = new GymEntities();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
        }
        #endregion
        #region  Command
        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand(() => obliczUtargClick());
                }
                return _ObliczCommand;

            }
        }
        private void obliczUtargClick()
        {
            Utarg = new HowC(gymEntities).RaportWynikC(IdKlienci, DataOd, DataDo);
        }


        #endregion
    }
}
