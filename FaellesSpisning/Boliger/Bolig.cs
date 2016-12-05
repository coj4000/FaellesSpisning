using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Boliger
{
    class Bolig : ObservableCollection<Person>
    {
        public Bolig() : base()
        {
            this.Add(new Person() { navn = "John Jonson", alder = 35, bolignr = 71, aldersgrænse = "Voksen"});

        }


        

    }
}
