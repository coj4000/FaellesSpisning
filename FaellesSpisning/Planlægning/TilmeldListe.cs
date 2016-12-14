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


        //    private TilmeldteBoliger bolig = new TilmeldteBoliger();
        //    private OpretUge uge = new OpretUge();
        //    public TilmeldListe()
        //    {

        //    }


        //    private void Mandag()
        //    {
        //        uge.Mandag.Add(bolig.Bolig1());
        //        uge.Mandag.Add(bolig.Bolig2());
        //        uge.Mandag.Add(bolig.Bolig3());
        //        uge.Mandag.Add(bolig.Bolig4());
        //        uge.Mandag.Add(bolig.Bolig5());
        //        uge.Mandag.Add(bolig.Bolig6());
        //        uge.Mandag.Add(bolig.Bolig7());
        //        uge.Mandag.Add(bolig.Bolig8());
        //        uge.Mandag.Add(bolig.Bolig9());
        //        uge.Mandag.Add(bolig.Bolig10());
        //    }

        //    private void Tirsdag()
        //    {
        //        uge.Tirsdag.Add(bolig.Bolig1());
        //        uge.Tirsdag.Add(bolig.Bolig2());
        //        uge.Tirsdag.Add(bolig.Bolig3());
        //        uge.Tirsdag.Add(bolig.Bolig5());
        //        uge.Tirsdag.Add(bolig.Bolig6());
        //        uge.Tirsdag.Add(bolig.Bolig7());
        //        uge.Tirsdag.Add(bolig.Bolig8());
        //        uge.Tirsdag.Add(bolig.Bolig9());
        //        uge.Tirsdag.Add(bolig.Bolig10());
        //    }

        //    private void Onsdag()
        //    {
        //        uge.Onsdag.Add(bolig.Bolig1());
        //        uge.Onsdag.Add(bolig.Bolig2());
        //        uge.Onsdag.Add(bolig.Bolig3());
        //        uge.Onsdag.Add(bolig.Bolig4());
        //        uge.Onsdag.Add(bolig.Bolig5());
        //        uge.Onsdag.Add(bolig.Bolig6());
        //        uge.Onsdag.Add(bolig.Bolig7());
        //        uge.Onsdag.Add(bolig.Bolig10());
        //    }

        //    private void Torsdag()
        //    {
        //        uge.Torsdag.Add(bolig.Bolig2());
        //        uge.Torsdag.Add(bolig.Bolig3());
        //        uge.Torsdag.Add(bolig.Bolig4());
        //        uge.Torsdag.Add(bolig.Bolig5());
        //        uge.Torsdag.Add(bolig.Bolig6());
        //        uge.Torsdag.Add(bolig.Bolig7());
        //        uge.Torsdag.Add(bolig.Bolig8());
        //        uge.Torsdag.Add(bolig.Bolig9());
        //    }

        //    private void Fredag()
        //    {
        //        uge.Fredag.Add(bolig.Bolig1());
        //        uge.Fredag.Add(bolig.Bolig3());
        //        uge.Fredag.Add(bolig.Bolig4());
        //        uge.Fredag.Add(bolig.Bolig5());
        //        uge.Fredag.Add(bolig.Bolig6());
        //        uge.Fredag.Add(bolig.Bolig10());
        //    }

    }
}
