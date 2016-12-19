using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using FaellesSpisning.Planlægning;

namespace FaellesSpisning.ViewModel
{
    class BoligViewModel : INotifyPropertyChanged
    {
        public Planlægning.TilmeldListe BoligListe { get; set; }

        private Boliger.Bolig selectedBolig;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Boliger.Bolig SelectedBolig
        {
            get { return selectedBolig; }
            set
            {
                selectedBolig = value;
                OnPropertyChanged(nameof(SelectedBolig));
            }
        }

        private readonly string filnavn = "JsonText.json";
        public BoligViewModel()
        {
            ViewSingleton.TilmeldListe = new Planlægning.TilmeldListe();

            BoligListe = new Planlægning.TilmeldListe();
            //AddGameCommand = new RelayCommand(AddNewGame, null);
            //AddBoligCommand = new AddBoligCommand(AddNewBolig);
            NewBolig = new Boliger.Bolig();
            //DeleteBoligCommand = new DeleteBoligCommand(DeleteBolig);
            //SaveBoligCommand = new SaveBoligCommand(GemDataTilDiskAsync);
            HentDataCommand = new HentDataCommand(HentDataFraDiskAsync);



            localFolder = ApplicationData.Current.LocalFolder;
        }

        public async void HentDataFraDiskAsync()
        {
            try
            {
                StorageFile file = await localFolder.GetFileAsync(filnavn);
                string jsonText = await FileIO.ReadTextAsync(file);
                this.BoligListe.Clear();
                BoligListe.indsætJson(jsonText);
            }
            catch (Exception)
            {

                MessageDialog messageDialog = new MessageDialog("Ændret filnavn eller der er ikke gemt");
                await messageDialog.ShowAsync();
            }



        }

        public async void GemDataTilDiskAsync()
        {
            string jsonText = this.BoligListe.GetJson();
            StorageFile file = await localFolder.CreateFileAsync(filnavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }
        //public AddBoligCommand AddBoligCommand { get; set; }
        //public DeleteBoligCommand DeleteBoligCommand { get; set; }
        public Boliger.Bolig NewBolig { get; set; }
        //public SaveBoligCommand SaveBoligCommand { get; set; }
        public HentDataCommand HentDataCommand { get; set; }

        private StorageFolder localFolder = null;

        //public RelayCommand AddGameCommand { get; set; }

        public void AddNewGame()
        {
            BoligListe.Add(NewBolig);
        }

        public void DeleteGame()
        {
            BoligListe.Remove(selectedBolig);
        }

        private class ViewSingleton
        {
            internal static TilmeldListe TilmeldListe;
        }
    }
}
