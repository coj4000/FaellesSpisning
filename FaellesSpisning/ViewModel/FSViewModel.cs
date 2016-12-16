using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.Planlægning;
using Windows.Storage;
using Windows.UI.Popups;
using Newtonsoft.Json;

namespace FaellesSpisning.ViewModel
{
      class FSViewModel : INotifyPropertyChanged
    {
      
       public ViewModelSingleton ViewSingleton { get { return ViewModelSingleton.Instance; } }
        public RedigerDagCommand RedigerDagCommand { get; set; }
        public Planlægning.Dag selectedDag;
        public Planlægning.Skema Skema { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        localFolder = ApplicationData.Current.LocalFolder;
      

        public FSViewModel()
        {
            ViewSingleton.TilmeldListe = new Planlægning.TilmeldListe();
            Skema = new Skema();

            SaveSkemaCommand = new SaveSkemaCommand(GemDataTilDiskAsync);
            HentDataCommand = new HentDataCommand(HentdataFraDiscAsync);

        }
        public async void HentdataFraDiscAsync()
        {

            try
            {
                this.Skema.Clear();
                StorageFile file = await localFolder.GetFileAsync(filnavn);
                string jsonText = await FileIO.ReadTextAsync(file);
                Skema.indsætJson(jsonText);
            }

            catch
            {
                MessageDialog messageDialog = new MessageDialog("Filnavn højst sandsynligt ændret eller der ikke er gemt");
                await messageDialog.ShowAsync();
            }

        }
        public async void GemDataTilDiskAsync()
        {
            string jsonText = this.Skema.GetJson();
            StorageFile file = await localFolder.CreateFileAsync(filnavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }

        public SaveSkemaCommand SaveSkemaCommand { get; set; }
        public HentDataCommand HentDataCommand { get; set; }

        private StorageFolder localFolder = null;


        public Planlægning.Dag SelectedDag
        {
            get { return selectedDag; }
            set
            {
                selectedDag = value;
                OnPropertyChanged(nameof(SelectedDag));
            }
        }
        private readonly string filnavn = "JsonText.json";

        public ViewModel.ViewModelSingleton VMSingleton { get; set; } = ViewModel.ViewModelSingleton.Instance;
    }
}
