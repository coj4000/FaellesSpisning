using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    class Skema
    {
        public Skema()
        {
            
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

        public void indsætJson(string jsonText)
        {
            List<Dag> NyListe = JsonConvert.DeserializeObject<List<Dag>>(jsonText);
            foreach (var dag in NyListe)
            {
                this.Add(dag);
            }
        }


    }
}
