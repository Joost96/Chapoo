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
        

        //Gemaakt door Mark. Haalt totaalbedrag op voor alle producten in 1 bestelling
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
        //Gemaakt door mark. Voert betalinggegevens in voor bestellingId
        public void UpdateBetaalStatus(int bestellingId, BetaalMethode betaalmethode, double fooi)
        {
            int betalingmethode = (int)betaalmethode;
            double totaalbedrag = getTotaalPrijsPerBestelling(bestellingId);
            BestellingDAO dao = new BestellingDAO();
            dao.UpdateBetaalStatus(bestellingId, betalingmethode, fooi, totaalbedrag);
        }


    }



}
