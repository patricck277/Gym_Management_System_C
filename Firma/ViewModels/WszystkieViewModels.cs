using Firma.Helpers;
using Firma.Models.Context;
using Firma.Models.Entities;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public abstract class WszystkieViewModels<T>:WorkspaceViewModel
    {

        #region DB
        //polaczenie  z  baza  danych
        protected readonly GymEntities gymEntities;
        #endregion

        #region Command
        private BaseCommand _LoadCommand;
        private BaseCommand _AddCommand;
        private BaseCommand _SortCommand;
        private BaseCommand _FindCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => load());
                }
                return _LoadCommand;
            }
        }

        
        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new BaseCommand(() => add());
                }
                return _AddCommand;
            }
        }
        #endregion
        #region Kolekcja
        private ObservableCollection<T> _List;
            public ObservableCollection<T> List


        {

            get
            {
                if (_List == null)
                {
                    load();
                }
                return _List;
            }

            set
            {
                _List = value;
                OnPropertyChanged(() => List);

            }
        }
        public string SortField { get; set; }
        public List<string> SortComboboxItems
        {
            get
            {
                return getComboboxSortList();
            }
        }
        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                {
                    _SortCommand = new BaseCommand(() => sort());
                }
                return _SortCommand;
            }
        }
        public string FindField { get; set; }
        public string FindTextBox { get; set; }
        public List<string> FindComboboxItems
        {
            get
            {
                return getComboboxFindList();
            }
        }
        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                {
                    _FindCommand = new BaseCommand(() => find());
                }
                return _FindCommand;
            }
        }


        #endregion


        #region  Constructor
        public WszystkieViewModels()
        {
            this.gymEntities = new GymEntities();
        }
        #endregion


        #region  Helpers
        public abstract void sort();
        public abstract List<String> getComboboxSortList();

        public abstract void find();
        public abstract List<String> getComboboxFindList();

        public abstract void load();
        private void add()
        {
            Messenger.Default.Send(DisplayName + "Add");
        }
        #endregion
    }
}
    

