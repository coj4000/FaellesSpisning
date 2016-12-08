using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Planlægning
{
    class TilmeldteBoliger
    {
        public string bolignavn;
        public int børnu3;
        public int børn;
        public int unge;
        public int voksne;
        public double hus1 { get; set; }
        public double hus2 { get; set; }
        public TilmeldteBoliger(int børnu3, int børn, int unge, int voksne, string bolignavn)
        {
            AntalKuverter(børnu3, børn, unge, voksne);
            this.bolignavn = bolignavn;
        }
    
        public double AntalBørn(int antal)
        {
            double result = antal * 0.25;
            return result;
        }

        public int AntalBørnU3(int antal)
        {
            int result = antal * 0;
            return result;
        }

        public double AntalUnge(int antal)
        {
            double result = antal * 0.5;
            return result;
        }

        public double AntalVoksne(int antal)
        {
            double result = antal * 1;
            return result;
        }

        public double AntalKuverter(int BørnU3, int Børn, int Unge, int Voksne)
        {
            double Kuverter = AntalBørnU3(BørnU3);
            Kuverter += AntalBørn(Børn);
            Kuverter += AntalUnge(Unge);
            Kuverter += AntalVoksne(Voksne);
            return Kuverter;
        }

        
    }
}
