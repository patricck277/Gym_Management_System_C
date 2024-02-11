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
    public class RaportOcenaViewModel : WorkspaceViewModel
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
        private int _IdTrener;
        public int IdTrener
        {
            get
            {
                return _IdTrener;
            }
            set
            {
                if (value != _IdTrener)
                {
                    _IdTrener = value;
                    OnPropertyChanged(() => IdTrener);
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
        public IQueryable<KeyAndValue> OcenaComboBoxItems
        {
            get
            {
                return new TrainT(gymEntities).GetTrainerKeyAndValueItems();
            }
        }

        #endregion
        #region  Constructor
        public RaportOcenaViewModel()
        {
            base.DisplayName = "Trainer Report";
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
            Utarg = new ScorT(gymEntities).RaportOcenaT(IdTrener, DataOd, DataDo);
        }


        #endregion
    }
}
