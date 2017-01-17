using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    class KeukenBarService
    {
       private BestellingDAO bestellingDal = new BestellingDAO();

        // bestelling status veranderen
        public void changeBestellingStatus(BestellingProduct product, BestellingStatus newStatus)
        {
            product.Status = newStatus;
        }
        public List<BestellingProduct> GetOpenBestellingen(List<BestellingProduct> producten)
        {
            List<BestellingProduct> openBestelling = new List<BestellingProduct>();

            foreach(BestellingProduct p in producten)
            {
               
                if (p.Status == BestellingStatus.Prepare || p.Status == BestellingStatus.Queue)
                {
                    openBestelling.Add(p);
                }
                          
            }

            return openBestelling;
        }
    }
}
