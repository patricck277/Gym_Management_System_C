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
using Firma.Models.EntitiesForView;

namespace Firma.ViewModels
{
    public class AddClassesViewModel : JedenViewModel<ZajeciaOfi>
    {

        #region  Constructor
        public AddClassesViewModel()
            : base("Add Classes")
        {
            item = new ZajeciaOfi();
        }
        #endregion  //  Constructor

        #region  Fields

        public string? NazwaZajec
        {
            get
            {
                return item.NazwaZajec;
            }
            set
            {
                if (item.NazwaZajec != value)
                {
                    item.NazwaZajec = value;
                    base.OnPropertyChanged(() => NazwaZajec);
                }
            }

        }
        public IQueryable<KeyAndValue> IdTrenerComboBoxItems
        {
            get
            {
                return
                    (

                    from trenerzy in gymEntities.Trenerzies
                    select new KeyAndValue
                    {
                        Key = trenerzy.IdTrener,
                        Value = trenerzy.Imie + " " + trenerzy.Nazwisko + " " + trenerzy.DataUrodzenia
                    }
                    ).ToList().AsQueryable();
            }
        }
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
                    base.OnPropertyChanged(() => DataRozpoczecia);
                }
            }

        }
        public TimeSpan? GodzinaRozpoczecia
        {
            get
            {
                return item.GodzinaRozpoczecia;
            }
            set
            {
                if (item.GodzinaRozpoczecia != value)
                {
                    item.GodzinaRozpoczecia = value;
                    base.OnPropertyChanged(() => GodzinaRozpoczecia);
                }
            }

        }
        public TimeSpan? GodzinaZakonczenia
        {
            get
            {
                return item.GodzinaZakonczenia;
            }
            set
            {
                if (item.GodzinaZakonczenia != value)
                {
                    item.GodzinaZakonczenia = value;
                    base.OnPropertyChanged(() => GodzinaZakonczenia);
                }
            }

        }
        public int? IdTrener
        {
            get
            {
                return item.IdTrenera;
            }
            set
            {
                if (item.IdTrenera != value)
                {
                    item.IdTrenera = value;
                    base.OnPropertyChanged(() => IdTrener);
                }
            }

        }

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

        #endregion  //  Fields

    }
}