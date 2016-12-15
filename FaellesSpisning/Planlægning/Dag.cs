using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FaellesSpisning.Planlægning
{
    public class Dag : INotifyPropertyChanged
    {
        private string _dage;
        private int _nummer;
        private string _ret;
        private string _chefKok;
        private string _kok;
        private string _opryder;

        public string Dage
        {
            get { return _dage; }
            set
            {
                _dage = value;
                OnPropertyChanged(nameof(Dage));
            }
        }

        public int Nummer
        {
            get { return _nummer; }
            set
            {
                _nummer = value;
                OnPropertyChanged(nameof(Nummer));
            }
        }

        public string Ret
        {
            get { return _ret; }
            set
            {
                _ret = value;
                OnPropertyChanged(nameof(Ret));
            }
        }

        public string ChefKok
        {
            get { return _chefKok; }
            set
            {
                _chefKok = value;
                OnPropertyChanged(nameof(ChefKok));
            }
        }

        public string Kok
        {
            get { return _kok; }
            set
            {
                _kok = value;
                OnPropertyChanged(nameof(Kok));
            }
        }

        public string Opryder
        {
            get { return _opryder; }
            set
            {
                _opryder = value;
                OnPropertyChanged(nameof(Opryder));
            }
        }

      


        public override string ToString()
        {
            return Dage + " Ret: " + Ret + " Chefkok: " + ChefKok + " Kok: " + Kok + " Opryder: " + Opryder;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
