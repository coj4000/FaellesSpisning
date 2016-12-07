using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Planlægning
{
    class Menu
    {
        public string ret { get; set; }
        public int pris { get; set; }
        public Menu(string ret, int pris)
        {
            this.ret = ret;
            this.pris = pris;
            
        }
    }
}
