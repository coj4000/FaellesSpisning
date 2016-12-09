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
      
        public TilmeldteBoliger()
        {
           
          
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

        public double Bolig1()
        {
            bolignavn = "Bolig 1";
            return AntalKuverter(1, 0, 1, 2);
        }
        public double Bolig2()
        {
            bolignavn = "Bolig 2";
            return AntalKuverter(0, 2, 0, 2);
        }
        public double Bolig3()
        {
            bolignavn = "Bolig 3";
            return AntalKuverter(0, 1, 1, 1);
        }
        public double Bolig4()
        {
            bolignavn = "Bolig 4";
            return AntalKuverter(2, 1, 0, 2);
        }
        public double Bolig5()
        {
            bolignavn = "Bolig 5";
            return AntalKuverter(0, 0, 1, 3);
        }
        public double Bolig6()
        {
            bolignavn = "Bolig 6";
            return AntalKuverter(1, 9, 0, 5);
        }
        public double Bolig7()
        {
            bolignavn = "Bolig 7";
            return AntalKuverter(3, 0, 0, 2);
        }
        public double Bolig8()
        {
            bolignavn = "Bolig 8";
            return AntalKuverter(0, 0, 1, 4);
        }
        public double Bolig9()
        {
            bolignavn = "Bolig 9";
            return AntalKuverter(0, 3, 0, 1);
        }
        public double Bolig10()
        {
            bolignavn = "Bolig 10";
            return AntalKuverter(1, 1, 1, 3);
        }



    }
}
