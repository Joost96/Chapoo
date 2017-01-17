using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    class KeukenBarService
    {
        private BestellingDAO bestellingDal = new BestellingDAO();

        // bestelling status veranderen
        public void changeBestellingStatus()
        {

        }
        /*
        // lijst met bestellingen ophalen
        public Bestelling getBestellingen()
        {
            return bestellingDal.ReadBestellingById(id);
        }

    */
    }
}
