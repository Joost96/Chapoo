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
        public List<TafelService.Prijzen> getTotaalPrijsPerBestelling(int bestellingId)
        {
            
            TafelService service = new TafelService();
            List<TafelService.Prijzen> prijslijst = service.GetPrijzen(bestellingId);


            return prijslijst;

        }

        public void UpdateBetaalStatus(int bestellingId)
        {
            BestellingDAO.Update
        }


    }



}
