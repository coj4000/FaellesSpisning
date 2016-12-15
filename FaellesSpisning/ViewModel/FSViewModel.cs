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
        
       

       public ViewModelSingleton ViewSingleton { get { return ViewModelSingleton.Instance; } }
        public RedigerDagCommand RedigerDagCommand { get; set; }
        public Planlægning.Dag selectedDag;
        public Planlægning.Dag RedigereDag { get; set; }
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
            ViewSingleton.TilmeldListe = new Planlægning.TilmeldListe();
            ViewSingleton.Skema = new Skema();
            RedigerDagCommand = new RedigerDagCommand(Rediger);
            
        }

        public void Rediger()
        {
            var dag = ViewSingleton.Skema.Where(d => d.Nummer == SelectedDag.Nummer).FirstOrDefault();
            if (dag != null)
            {
                dag.Ret = selectedDag.Ret;
                dag.ChefKok = selectedDag.ChefKok;
                dag.Kok = selectedDag.Kok;
                dag.Opryder = selectedDag.Opryder;
            }
        }
        public Planlægning.Dag SelectedDag
        {
            get { return selectedDag; }
            set
            {
                selectedDag = value;
                OnPropertyChanged(nameof(SelectedDag));
            }
        }

        public ViewModel.ViewModelSingleton VMSingleton { get; set; } = ViewModel.ViewModelSingleton.Instance;
    }
}
