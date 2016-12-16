using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.FaceAnalysis;

namespace FaellesSpisning.Boliger
{
   public class Bolig : INotifyPropertyChanged
   {
       public double BørnU3;
       public double Børn;
       public double Unge;
       public double Voksne;
       public int bolignr;
       public double PrisPerDag;
       //public double AntalKuverterIAlt;
       public double samletpris;
       public bool mandag;
       public bool tirsdag;
       public bool onsdag;
       public bool Torsdag;
       public bool Fredag;
       public int husKuverter;

        // har matias added efter inotify
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        //public Bolig(int bolignr)
        //{
        //    this.bolignr = bolignr;
        //}



        public double AntalKuverter()
       {
           return AntalBørnU3() + AntalBørn() + AntalUnge() + AntalVoksne();
       }

        public double AntalBørnU3()
        {
            double result = BørnU3 * 0.00;
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
        
       public double GennemsnitsKuvertspris()
       {
           return samletpris/AntalKuverter();
       }

       public double SamletPrisPerBolig()
       {
           return AntalKuverter()*GennemsnitsKuvertspris();
       }
        

 



        public override string ToString()
        {
            return "Bolig Nr: " + bolignr + " Bu3: " + BørnU3 + " B: " + Børn + " U: " + Unge + " V: " + Voksne;
        }

       



       // public Bolig(double BørnU3, double Børn, double Unge, double Voknse)
       // {
       //     this.BørnU3 = BørnU3;
       //     this.Børn = Børn;
       //     this.Unge = Unge;
       //     this.Voksne = Voksne;
       // }

       //public double DeltagerSum()
       //{
       //    double result = 0;
       //    result = result + BørnU3;
       //    result = result + Børn;
       //    result = result + Unge;
       //    result = result + Voksne;
       //    return result;

       public double SumAfDeltagere()
       {
           double total = 0;
           AntalKuverter();
           total = total + AntalKuverter();
           return total;
       }

       //}
        public void totalKuvert(double husKurveter)
       {
           if (husKuverter < 0)
            {
                throw new ArgumentOutOfRangeException("memes");
            }
       }



    }
}
