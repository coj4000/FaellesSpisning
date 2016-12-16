using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.ViewModel;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
   public class Skema : ItemsChangeObservableCollection<Dag>
    {
        public Skema() : base()
        {
            this.Add(new Dag() {Dage = "Mandag", Nummer = 1, Ret = "", ChefKok = "TEST", Kok = "", Opryder = ""});
            this.Add(new Dag() {Dage = "Tirsdag", Nummer = 2, Ret = "", ChefKok = "", Kok = "", Opryder = ""});
            this.Add(new Dag() {Dage = "Onsdag", Nummer = 3, Ret = "", ChefKok = "", Kok = "", Opryder = ""});
            this.Add(new Dag() {Dage = "Torsdag", Nummer = 4, Ret = "", ChefKok = "", Kok = "", Opryder = ""});
            this.Add(new Dag() {Dage = "Fredag", Nummer = 5, Ret = "", ChefKok = "", Kok = "", Opryder = ""});
        }

       
        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }



        
        public void indsætJson(string jsonText)
        {
            List<Dag> NyListe = JsonConvert.DeserializeObject<List<Dag>>(jsonText);
            foreach (var dag in NyListe)
            {
                this.Add(dag);
            }
        }
        public double TotalPris()
        {
            double pris = 0;
            return pris;
        }


        



    }
}
