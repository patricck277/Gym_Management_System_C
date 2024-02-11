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
    public class ProductsViewModel : WszystkieViewModels<ProductsForView>
    {

        #region  Constructor
        public ProductsViewModel()
        : base()
        {
            base.DisplayName = "Products";
        }

        #endregion


        #region  Helpers
        public override void load()
        {
            List = new ObservableCollection<ProductsForView>
            (from produkty in gymEntities.Produkties select new ProductsForView

            {
                IdProdukty = produkty.IdProdukty,
                NazwaProduktu = produkty.NazwaProduktu,
                Cena = produkty.Cena,
                IloscDostepna = produkty.IloscDostepna,
                Aktywnosc = produkty.Aktywnosc,
                KtoDodal = produkty.KtoDodalNavigation.IdPracownicy + " " + produkty.KtoDodalNavigation.Imie + " " + produkty.KtoDodalNavigation.Nazwisko,
                KiedyDodane = produkty.KiedyDodane

            }
             
             
             );
           
        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa Produktu", "Cena", "Ilosc Dostepna" };
        }
        public override void sort()
        {

            if (SortField == "Nazwa Produktu")
                List = new ObservableCollection<ProductsForView>(List.OrderBy(item => item.NazwaProduktu));
            if (SortField == "Cena")
                List = new ObservableCollection<ProductsForView>(List.OrderBy(item => item.Cena));
            if (SortField == "Ilosc Dostepna")
                List = new ObservableCollection<ProductsForView>(List.OrderBy(item => item.IloscDostepna));

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa Produktu" };
        }
        public override void find()
        {
            if (FindField == "Nazwa Produktu")
                List = new ObservableCollection<ProductsForView>(List.Where(item => item.NazwaProduktu
           != null && item.NazwaProduktu.StartsWith(FindTextBox)));
        }
        #endregion
    }
}
