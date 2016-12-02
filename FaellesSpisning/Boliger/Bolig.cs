﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Boliger
{
    class Bolig
    {


        public Bolig()
        {

        }

        public string Beboer(string navn, int alder)
        {

            string grænse = Aldersgrænse(alder);
            string navnet = navn;
            
            return navn;
        }

        private string Aldersgrænse(int alder)
        {
            string grænse;
            if (alder > 15)
            {
                grænse = "Voksen";
            }
            if (alder >= 7 && alder <= 15)
            {
                grænse = "Ung";
            }
            if (alder >= 3 && alder <= 6)
            {
                grænse = "Barn";
            }
            if (alder < 3 && alder > 0)
            {
                grænse = "BarnU3";
            }
            if (alder < 0)
            {
                grænse = "Umugelit";
            }
            return grænse;

        }

    }
}
