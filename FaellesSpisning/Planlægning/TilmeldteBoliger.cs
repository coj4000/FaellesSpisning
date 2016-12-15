using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using FaellesSpisning.Boliger;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    class TilmeldteBoliger : ObservableCollection<Bolig>
    {
        public Bolig Fisk = new Bolig();

        



        public TilmeldteBoliger() : base()
        {
           this.Add(new Bolig() {});
          
       
        }

        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        



    }
}
