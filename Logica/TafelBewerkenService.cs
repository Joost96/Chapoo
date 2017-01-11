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
            List<BestellingProduct> bestelling = BestellingProductDAO.ReadAllFromBestellingProducten(bestellingId);

           return bestelling;

        }

        public List<BestellingProduct> PasAantalAan (int verschilAantal,int productId, List<BestellingProduct> bestelling)
        {
         
                      foreach(BestellingProduct p in bestelling)
                      {
                          if (p.Id == productId )
                          {
                              p.Aantal = p.Aantal + verschilAantal;
                          }
                      }

            return bestelling;
        }

    }
}
