using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class KeukenBarService
    {
        private BestellingDAO bestellingDAO = new BestellingDAO();
        private BestellingProductDAO bestellingProductDAO = new BestellingProductDAO();

        // bestelling status veranderen
        public void changeBestellingStatus(BestellingProduct product, BestellingStatus newStatus)
        {
            bestellingProductDAO.updateBestellingProduct(product, newStatus);
        }

        public List<BestellingProduct> GetOpenBestellingen(bool isKeuken)
        {
            return bestellingDAO.ReadKeukenBarOverzicht(isKeuken);
        }
    }
}
