using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Boliger
{
   public class Bolig
    {
        public int BørnU3 { get; set; }
        public int Børn { get; set; }
        public int Unge { get; set; }
        public int Voksne { get; set; }
        public int bolignr { get; set; }
        //public Bolig(int bolignr)
        //{
        //    this.bolignr = bolignr;
        //}

        public override string ToString()
        {
            return "Bolig Nr: " + bolignr + " Bu3: " + BørnU3 + " B: " + Børn + " U: " + Unge + " V: " + Voksne;
        }





    }
}
