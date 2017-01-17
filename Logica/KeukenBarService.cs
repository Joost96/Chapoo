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

        public void changeBestellingStatus(int best)
        {
            bool

        }

        public Bestelling getBestelling(int id)
        {
            return bestellingDal.ReadBestellingById(id);
        }


    }
}
