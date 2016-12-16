using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using FaellesSpisning.Boliger;
using FaellesSpisning.ViewModel;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    class TilmeldteBoliger : ObservableCollection<Bolig>
    {
                
        // added af matias for samletpris (no workerino)
        public TilmeldteBoliger() : base()
        {
           this.Add(new Bolig() {samletpris = 0.0}); 
          
       
        }

        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        




    }
}
