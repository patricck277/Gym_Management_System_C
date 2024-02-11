using Firma.Helpers;
using Firma.Models.Context;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class EquipmentViewModel : WszystkieViewModels<EquipmentForView>
    {

        #region  Constructor
        public EquipmentViewModel()
        : base()
        {
            base.DisplayName = "Equipment";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<EquipmentForView>
            (
                from sprzet in gymEntities.Sprzets select new EquipmentForView

                {
                    IdSprzet = sprzet.IdSprzet,
                    NazwaSprzetu = sprzet.NazwaSprzetu,
                    Producent = sprzet.Producent,
                    RokProdukcji = sprzet.RokProdukcji,
                    IloscDostepnych = sprzet.IloscDostepnych,
                    Aktywnosc = sprzet.Aktywnosc,
                    KtoDodal = sprzet.KtoDodalNavigation.IdPracownicy + " " + sprzet.KtoDodalNavigation.Imie + " " + sprzet.KtoDodalNavigation.Nazwisko,
                    KiedyDodane = sprzet.KiedyDodane,

                }
                
                
                );

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa Sprzetu", "Producent" };
        }
        public override void sort()
        {

            if (SortField == "Nazwa Sprzetu")
                List = new ObservableCollection<EquipmentForView>(List.OrderBy(item => item.NazwaSprzetu));
            if (SortField == "Producent")
                List = new ObservableCollection<EquipmentForView>(List.OrderBy(item => item.Producent));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "NazwaSprzetu", "Producent" };
        }
        public override void find()
        {
            if (FindField == "Nazwa Sprzetu")
                List = new ObservableCollection<EquipmentForView>(List.Where(item => item.NazwaSprzetu
           != null && item.NazwaSprzetu.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<EquipmentForView>(List.Where(item => item.Producent != null && item.Producent.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
