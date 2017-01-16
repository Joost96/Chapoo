using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;


namespace Logica
{
    public class BetalenService
    {
        public List<BestellingProduct> getBestellingProducten(int bestellingId)
        {
            List<BestellingProduct> bestelling = BestellingDAO.ReadAllFromBestellingProducten(bestellingId);

            return bestelling;

        }


        public struct Prijzen getTotaalPrijsPerBestelling(int bestellingId)
        {
            
            TafelService service = new TafelService();
            List<Prijzen> prijslijst = service.GetPrijzen(bestellingId);


            return prijs;
        }


    }



}
