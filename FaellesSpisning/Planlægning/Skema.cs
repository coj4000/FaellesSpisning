using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
   public class Skema : ObservableCollection<Dag>
    {
        public Skema() : base()
        {
            this.Add(new Dag() {Dage = "Mandag", Nummer = 1, Ret = "", ChefKok = "", Kok = "", Opryder = "", Pris = 0});
            this.Add(new Dag() {Dage = "Tirsdag", Nummer = 2, Ret = "", ChefKok = "", Kok = "", Opryder = "", Pris = 0});
            this.Add(new Dag() {Dage = "Onsdag", Nummer = 3, Ret = "", ChefKok = "", Kok = "", Opryder = "", Pris = 0});
            this.Add(new Dag() {Dage = "Torsdag", Nummer = 4, Ret = "", ChefKok = "", Kok = "", Opryder = "", Pris = 0});
            this.Add(new Dag() {Dage = "Fredag", Nummer = 5, Ret = "", ChefKok = "", Kok = "", Opryder = "", Pris = 0});
        }

        public void Add()
        {

        }

        public void Delete()
        {

        }
        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public double TotalPris()
        {
            double pris = 0;
            return pris;
        }
       



    }
}
