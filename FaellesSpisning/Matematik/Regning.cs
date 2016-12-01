using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.Matematik
{
    class Regning
    {
        Boliger.Bolig bolig = new Boliger.Bolig();
        int pris;
        double total;
        double sumV;
        double sumU;
        double sumB;
        double sumBu3;
        
        public double Total()
        {
            total = 0;

            if (bolig.voksenantal > 0)
            {
                total = pris * (bolig.voksenantal * 1);
            }
            if (bolig.unge > 0)
            {
                total += pris * (bolig.unge * 0.5);
            }
            if (bolig.børn > 0)
            {
                total += pris * (bolig.børn * 0.25);
            }
            if (bolig.børnu3 > 0)
            {
                total += pris * (bolig.børnu3 * 0.00000);
            }
            //Christain fix this

            
            return total;
            
        }
        
    
    }

}
