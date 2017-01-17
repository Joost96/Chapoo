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
<<<<<<< HEAD
        private BestellingDAO bestellingDal = new BestellingDAO();

        // bestelling status veranderen
        public void changeBestellingStatus()
=======
        public BestellingProduct ChangeStatus(BestellingProduct product, BestellingStatus newStatus)
>>>>>>> origin/master
        {
            product.Status = newStatus;
            return product;
        }
<<<<<<< HEAD
        /*
        // lijst met bestellingen ophalen
        public Bestelling getBestellingen()
=======

        public List<BestellingProduct> GetOpenBestellingen(List<BestellingProduct> producten)
>>>>>>> origin/master
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

<<<<<<< HEAD
    */
=======

            
        
>>>>>>> origin/master
    }
}
