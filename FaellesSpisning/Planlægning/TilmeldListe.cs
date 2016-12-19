using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.Boliger;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    public class TilmeldListe : ObservableCollection<Bolig>
    {
        public TilmeldListe() : base()
        {
            this.Add(new Bolig() { bolignr = 1, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2 });
            this.Add(new Bolig() { bolignr = 2, BørnU3 = 0, Børn = 3, Unge = 0, Voksne = 2 });
            this.Add(new Bolig() { bolignr = 3, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 3 });
            this.Add(new Bolig() { bolignr = 4, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2 });
            this.Add(new Bolig() { bolignr = 5, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 2 });
            this.Add(new Bolig() { bolignr = 6, BørnU3 = 0, Børn = 2, Unge = 0, Voksne = 1 });
            this.Add(new Bolig() { bolignr = 7, BørnU3 = 3, Børn = 1, Unge = 0, Voksne = 3 });
            this.Add(new Bolig() { bolignr = 8, BørnU3 = 2, Børn = 1, Unge = 1, Voksne = 2 });
            this.Add(new Bolig() { bolignr = 9, BørnU3 = 0, Børn = 3, Unge = 1, Voksne = 1 });
            this.Add(new Bolig() { bolignr = 10, BørnU3 = 0, Børn = 0, Unge = 3, Voksne = 2 });


        }

        public double prisPrKuvert(double ugepris)
        {
            double res = 0;

            foreach (var bo in this)
            {
                res = res + bo.AntalKuverter();
            }

            res = ugepris/res;

            return res;
        }

        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public void indsætJson(string jsonText)
        {
            List<Bolig> NyListe = JsonConvert.DeserializeObject<List<Bolig>>(jsonText);
            foreach (var bolig in NyListe )
            {
                this.Add(bolig);
            }
        }

    }
}
