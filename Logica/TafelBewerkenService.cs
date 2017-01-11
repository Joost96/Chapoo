using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;


namespace Logica
{
    public class TafelBewerkenService
    {
        public List<BestellingProduct> getBestellingProducten(int bestellingId)
        {
           List<BestellingProduct> bestelling = ( ReadAllFromBestellingProducten(bestellingId));

           return bestelling;

        }

        public List<BestellingProduct> PasAantalAan ()
        {
            List<BestellingProduct> bestelling = new List<BestellingProduct>();


            return bestelling;
        }

    }
}
