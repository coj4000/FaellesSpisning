using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaellesSpisning.Planlægning;

namespace FaellesSpisning.ViewModel
{
    public sealed class TilmeldListeSingleton
    {
        public static TilmeldListeSingleton instance { get; set; } = new TilmeldListeSingleton();

        public TilmeldListe MandagListe { get; set; } = new TilmeldListe();

        public TilmeldListeSingleton()
        {
            MandagListe = new TilmeldListe();
        }

        public double HentBolig(TilmeldListe mandaListe)
        {
            double hussum = 0;
            foreach (var hus in MandagListe)
            {
                double sum = hus.Børn + hus.BørnU3 + hus.Unge + hus.Voksne;
                hussum = sum*hus.AntalKuverter();
            }
            return hussum;

        }

       
    }
}
