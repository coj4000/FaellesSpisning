﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.Planlægning;
using Windows.Storage;
using Windows.UI.Popups;
using FaellesSpisning.Boliger;
using Newtonsoft.Json;

namespace FaellesSpisning.ViewModel
{
      class FSViewModel : INotifyPropertyChanged
    {
      
       public ViewModelSingleton ViewSingleton { get { return ViewModelSingleton.Instance; } }
        public RedigerDagCommand RedigerDagCommand { get; set; }
        public Planlægning.Dag selectedDag;
        public Planlægning.Skema Skema { get; set; }

        public Planlægning.Bolig
        


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        StorageFolder localfolder = null;


        
      

        public FSViewModel()
        {
            ViewSingleton.TilmeldListe = new Planlægning.TilmeldListe();
            Skema = new Skema();

            SaveSkemaCommand = new SaveSkemaCommand(GemDataTilDiskAsync);
            HentDataCommand = new HentDataCommand(HentdataFraDiscAsync);
            SavePrisCommand = new SavePrisCommand(GemPrisTilDiskAsync);

            Boligen = new bol

            localfolder = ApplicationData.Current.LocalFolder;


        }
        public async void HentdataFraDiscAsync()
        {

            try
            {
                this.Skema.Clear();
                StorageFile file = await localfolder.GetFileAsync(filnavn);
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
            StorageFile file = await localfolder.CreateFileAsync(filnavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }

        public SaveSkemaCommand SaveSkemaCommand { get; set; }
        public HentDataCommand HentDataCommand { get; set; }
        public SavePrisCommand SavePrisCommand { get; set; }
        public HentPrisCommand HentPrisCommand { get; set; }

        public async void GemPrisTilDiskAsync()
        {
            string jsonText = this.Bolig.GetJson();
            StorageFile file = await localfolder.CreateFileAsync(filnavn2, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }       

        public async void HentPrisFraDiskAsync()
        {
            // her var der en clear.skema
            StorageFile file = await localfolder.GetFileAsync(filnavn2);
            string jsonText = await FileIO.ReadTextAsync(file);
            Skema.indsætJson(jsonText);
        }


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
        private readonly string filnavn2 = "JsonPris.json";

        public ViewModel.ViewModelSingleton VMSingleton { get; set; } = ViewModel.ViewModelSingleton.Instance;
    }
}
