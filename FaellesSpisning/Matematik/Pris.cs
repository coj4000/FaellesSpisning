using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Matematik
{
    class Pris : INotifyPropertyChanged
    {
        private int _bolignr;
        private double _samletpris;

        public Pris()
        {

        }

        public Pris(int bolignr, double samletpris)
        {
            _bolignr = bolignr;
            _samletpris = samletpris;
        }

        public int Bolignr
        {
            get { return _bolignr; }
            set
            {
                _bolignr = value;
                OnPropertyChanged(nameof(Bolignr));
            }
        }


        public double Samletpris
        {
            get { return _samletpris; }
            set
            {
                _samletpris = value;
                OnPropertyChanged(nameof(Samletpris));
            }
        }

        public override string ToString()
        {
            return "Ugentlig pris:  " + Samletpris;
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

