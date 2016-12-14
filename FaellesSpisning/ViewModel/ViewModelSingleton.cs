using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.Planlægning;

namespace FaellesSpisning.ViewModel
{
    public class ViewModelSingleton
    {
        private static ViewModelSingleton instance;
        private ViewModelSingleton() { }

        public static ViewModelSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViewModelSingleton();
                }
                return instance;
            }
        }
        public Boliger.Bolig SelectedBolig { get; set; }
        public Dag SelectedDag { get; set; }
    }
}
