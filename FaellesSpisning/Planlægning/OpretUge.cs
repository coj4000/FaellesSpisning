using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Planlægning
{
    public class OpretUge
    {
        public List<double> Mandag;
        public List<double> Tirsdag;
        public List<double> Onsdag;
        public List<double> Torsdag;
        public List<double> Fredag;
        public OpretUge()
        {
            List<string> Mandag = new List<string>();
            List<string> Tirsdag = new List<string>();
            List<string> Onsdag = new List<string>();
            List<string> Torsdag = new List<string>();
            List<string> Fredag = new List<string>();
        }
       
    }
}
