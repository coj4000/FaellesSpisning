using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Planlægning
{
    class TilmeldListe : ObservableCollection<TilmeldteBoliger>
    {
        public TilmeldListe() : base()
        {
            this.Add(new TilmeldteBoliger(1,0,2,2,"Bolig1"));
            
            int antal = 25;
           

        }
    }
}
