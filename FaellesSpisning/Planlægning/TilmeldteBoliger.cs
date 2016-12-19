using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using FaellesSpisning.Boliger;
using FaellesSpisning.Matematik;
using FaellesSpisning.ViewModel;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    class TilmeldteBoliger : ItemsChangeObservableCollection<Pris>
    {
                
        // added af matias for samletpris (no workerino)
        public TilmeldteBoliger() : base()
        {
           this.Add(new Pris() {Samletpris = 0}); 
           this.Add(new Pris() {Samletpris = 0});
           this.Add(new Pris() {Samletpris = 0 });


        }

        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        




    }
}
