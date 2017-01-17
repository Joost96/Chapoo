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
        public BestellingProduct ChangeStatus(BestellingProduct product, BestellingStatus newStatus)
        {
            product.Status = newStatus;
            return product;
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
