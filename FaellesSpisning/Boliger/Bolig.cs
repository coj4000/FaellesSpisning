﻿using System;
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
        
       public double GennemsnitsKuvertspris()
       {
           return samletpris/AntalKuverter();
       }
       

       public double BørnePris()
       {
           return GennemsnitsKuvertspris()*0.25;
       }

       public double UngePris()
       {
           return GennemsnitsKuvertspris()*0.5;
       }

       public double Voksenpris()
       {
           return GennemsnitsKuvertspris();
       }
        

 



        public override string ToString()
        {
            return "Bolig Nr: " + bolignr + " Bu3: " + BørnU3 + " B: " + Børn + " U: " + Unge + " V: " + Voksne;
        }
       

       public double SumAfDeltagere()
       {
           double total = 0;
           AntalKuverter();
           total = total + AntalKuverter();
           return total;
       }


        public void totalKuvert(double husKurveter)
       {
           if (husKuverter < 0)
            {
                throw new ArgumentOutOfRangeException("memes");
            }
       }



    }
}
