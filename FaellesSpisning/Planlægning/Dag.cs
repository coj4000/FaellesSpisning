using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    class Dag
    {
        public string Dage { get; set; }
        public int Nummer  { get; set; }
        public string Ret { get; set; }
        public string ChefKok { get; set; }
        public string Kok { get; set; }
        public string Opryder { get; set; }
        public double Pris { get; set; }
        

        public override string ToString()
        {
            return Dage + " Ret: " + Ret + " Chefkok: " + ChefKok + " Kok: " + Kok + " Opryder: " + Opryder;
        }


    }
}
