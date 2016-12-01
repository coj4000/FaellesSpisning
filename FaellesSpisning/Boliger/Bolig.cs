using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Boliger
{
    class Bolig
    {
        public int voksenantal;
        public int unge;
        public int børn;
        public int børnu3;

        Beboere beboere = new Beboere();
        public Bolig()
        {

        }

        public void Bolig1(string voksne, int unge, int børn, int børnu3)
        {
            voksenantal = 1;
        }

        public void Bolig2(string voksne, string voksne2, int unge, int børn, int børnu3)
        {
            voksenantal = 2;
        }

        public void Bolig3(string voksne, string voksne2, string voksne3, int unge, int børn, int børnu3)
        {
            voksenantal = 3;
        }

        public void Bolig4(string voksne, string voksne2, string voksne3, string voksne4, int unge, int børn, int børnu3)
        {
            voksenantal = 4;
        }

    }
}
