using Firma.Helpers;
using Firma.Models.Context;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Firma.ViewModels
{
    public class JedenViewModel<T>:WorkspaceViewModel
    {
        #region  DB
        protected GymEntities gymEntities;
        protected T item;
        #endregion

        #region
        //SAVE AND CLOSE
        private BaseCommand _SaveAndCloseCommand;
        public ICommand SaveAndCloseCommand
        {
            get
            {
                if (_SaveAndCloseCommand == null)
                    _SaveAndCloseCommand = new BaseCommand(SaveAndClose);
                return _SaveAndCloseCommand;
            }
        }

        //SAVE
        private BaseCommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(Save);
                return _SaveCommand;
            }
        }
        // CANCEL COMMAND
        private ICommand _CancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new BaseCommand(Cancel);
                return _CancelCommand;
            }
        }

        /// <summary>
        public string SomeText { get; set; }
        public DateTime? SomeDate { get; set; }
        /// </summary>


        #endregion

        #region  Constructor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;
            gymEntities = new GymEntities();
        }
        #endregion  //  Constructor

        #region Helpers
        public void Save()
        {
            if (IsValid())
            {
                gymEntities.Add(item);
                gymEntities.SaveChanges();
            }
            else
                MessageBox.Show("Invalid data");
        }
        private void SaveAndClose()
        {
            if (IsValid())
            {
                Save();
                OnRequestClose();
            }
            else
                MessageBox.Show("Invalid data");
        }
        private void Cancel()
        {
            SomeText = string.Empty;
            SomeDate = null; 

            OnPropertyChanged(() => SomeText);
            OnPropertyChanged(() => SomeDate);
        }

        #endregion
        #region Validation
        public virtual bool IsValid()
        {
            return true;
        }    
        #endregion
    }
}
