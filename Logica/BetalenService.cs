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
        

        //Gemaakt door Mark. Haalt een lijst op van de prijzen van alle product in voor 1 bestellingid
        public double getTotaalPrijsPerBestelling(int bestellingId)
        {
            double totaalbedrag = 0;
            TafelService service = new TafelService();
            List<TafelService.Prijzen> prijslijst = service.GetPrijzen(bestellingId);

            foreach(TafelService.Prijzen p in prijslijst)
            {
                totaalbedrag += p.productMetBTW;
            }
            return totaalbedrag;

        }

        public void UpdateBetaalStatus(int bestellingId, BetaalMethode betaalmethode, double fooi)
        {
            BetaalMethode betaling = new BetaalMethode();
            double totaalbedrag = getTotaalPrijsPerBestelling(bestellingId);
            //BestellingDAO.UpdateBetaalStatus(bestellingId,  betaling, fooi, totaalbedrag);
        }


    }



}
