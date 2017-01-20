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

        public void UpdateBetaalStatus(int tafelId, BetaalMethode betaalmethode, double fooi, string commentaar)
        {
            int betalingmethode = (int)betaalmethode;
            double totaalbedrag = tservice.GetSubtotaal(tafelId);
            BestellingDAO dao = new BestellingDAO();
            dao.BetaalBestelling(tafelId, betalingmethode, fooi, totaalbedrag, commentaar);
            tafelDAO.UpdateStatus(tafelId, TafelStatus.Vrij);
        }

        public double brekenSubtotaal (int tafelId)
        {
            double sub = tservice.GetSubtotaal(tafelId) - tservice.GetBtwTotaal(tafelId);
            return sub;
        }
    }
}