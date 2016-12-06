using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Boliger
{
    class Person
    {
        public string navn { get; set; }
        public int alder { get; set; }
        public int bolignr { get; set; }
        public string aldersgrænse { get; set; }

        public Person(string navn, int alder, int bolignr)
        {
            this.navn = navn;
            this.alder = alder;
            this.bolignr = bolignr;
            this.aldersgrænse = Aldersgrænse(alder);
        }

        private string Aldersgrænse(int alder)
        {

            string grænse = "";
            if (alder > 15)
            {
                grænse = "Voksen";
                return grænse;
            }
            if (alder >= 7 && alder <= 15)
            {
                grænse = "Ung";
                return grænse;
            }
            if (alder >= 3 && alder <= 6)
            {
                grænse = "Barn";
                return grænse;
            }
            if (alder < 3 && alder > 0)
            {
                grænse = "BarnU3";
                return grænse;
            }
            if (alder < 0)
            {
                grænse = "Umugelit";
                return grænse;
            }
            return grænse;

        }

        public override string ToString()
        {
            return navn + " " + alder + " " + aldersgrænse;
        }

    }
}
