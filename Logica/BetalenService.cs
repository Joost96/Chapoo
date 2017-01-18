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
        public double getTotaalPrijsPerBestelling(int tafelId)
        {
            double totaalbedrag = 0;
            TafelService service = new TafelService();
            List<TafelService.Prijzen> prijslijst = service.GetPrijzen(tafelId);

            foreach(TafelService.Prijzen p in prijslijst)
            {
                totaalbedrag += p.productMetBTW;
            }
            return totaalbedrag;

        }
        //Gemaakt door mark. Voert betalinggegevens in voor bestellingId
        public void UpdateBetaalStatus(int tafelId, BetaalMethode betaalmethode, double fooi, string commentaar)
        {
            int betalingmethode = (int)betaalmethode;
            double totaalbedrag = getTotaalPrijsPerBestelling(tafelId);
            BestellingDAO dao = new BestellingDAO();
            dao.UpdateBetaalStatus(tafelId, betalingmethode, fooi, totaalbedrag, commentaar);
        }


    }



}
