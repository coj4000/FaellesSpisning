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
       public double BørnU3;
       public double Børn;
       public double Unge;
       public double Voksne;
       public int bolignr;
       public double PrisPerDag;
        //public Bolig(int bolignr)
        //{
        //    this.bolignr = bolignr;
        //}
        public double GetAntalKuverterIHusstand()
        {
            return AntalBørnU3() + AntalBørn() + AntalUnge() + AntalVoksne();
        }
        

       public double AntalKuverter()
       {
           return AntalBørnU3() + AntalBørn() + AntalUnge() + AntalVoksne();
       }

        public double AntalBørnU3()
        {
            double result = BørnU3 * 0.0;
            return result;
        }
        public double AntalBørn()
        {
            double result = Børn * 0.25;
            return result;
        }
        public double AntalUnge()
        {
            double result = Unge * 0.5;
            return result;
        }

        public double AntalVoksne()
        {
            double result = Voksne * 1;
            return result;
        }

        public int AntalVoksneIHusstand { get; set; }
        public int AntalTeenagerIHusstand { get; set; }
        public int AntalBarnIHusstand { get; set; }
        public int AntalBabyIHusstand { get; set; }
        public string HusNummer { get; set; }




        public override string ToString()
        {
            return "Bolig Nr: " + bolignr + " Bu3: " + BørnU3 + " B: " + Børn + " U: " + Unge + " V: " + Voksne;
        }





    }
}
