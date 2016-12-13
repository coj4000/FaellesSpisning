using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.Planlægning;

namespace FaellesSpisning.ViewModel
{
      class FSViewModel : INotifyPropertyChanged
    {
        public Planlægning.TilmeldListe TilmeldListe { get; set; }
        public Skema Skema { get; set; }

        private Boliger.Bolig SelectedBolig;
        private Dag SelectedDag;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public FSViewModel()
        {
            TilmeldListe = new Planlægning.TilmeldListe();
            Skema = new Skema();
            
        }

        public ViewModel.ViewModelSingleton VMSingleton { get; set; } = ViewModel.ViewModelSingleton.Instance;
    }
}
