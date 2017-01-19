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

        private TafelDAO tafelDAO = new TafelDAO();
        private TafelService tservice = new TafelService();
        //Gemaakt door Mark. Haalt totaalbedrag op voor alle producten in 1 bestelling
        /*public double getTotaalPrijsPerBestelling(int tafelId)
        {
            double totaalbedrag = 0;
            TafelService service = new TafelService();
            //List<TafelService.Prijzen> prijslijst = service.GetSubtotaal(tafelId);

            foreach(TafelService.Prijzen p in prijslijst)
            {
                totaalbedrag += p.productMetBTW;
            }
            return totaalbedrag;

        }*/
        //Gemaakt door mark. Voert betalinggegevens in voor bestellingId
        public void UpdateBetaalStatus(int tafelId, BetaalMethode betaalmethode, double fooi, string commentaar)
        {
            int betalingmethode = (int)betaalmethode;
            double totaalbedrag = tservice.GetTotaal(tafelId);
            BestellingDAO dao = new BestellingDAO();
            dao.BetaalBestelling(tafelId, betalingmethode, fooi, totaalbedrag, commentaar);
            tafelDAO.UpdateStatus(tafelId, TafelStatus.Vrij);
        }


    }



}
