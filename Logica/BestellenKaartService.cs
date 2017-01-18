using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    // Shahin
    // door design aanpassing samengevoegd -> BestellenOverzichtService + BestelKaartService
    public class BestellenKaartService
    {
        private KaartDAO kaartDAO = new KaartDAO();
        private BestellingDAO bestellingDAO = new BestellingDAO();
        private TafelDAO tafelDAO = new TafelDAO();
        public List<Product> GetAllProductenFromKaart(int KaartId)
        {
            List<Product> menuKaart = kaartDAO.ReadAllProduct(KaartId);
            return menuKaart;
        }

        public Bestelling getBestellingByTafelId(int id)
        {
            return bestellingDAO.ReadBestellingByTafelId(id);
        }
        public void AddToBestelling(List<BestellingProduct> producten, Bestelling bestelling,Werknemer werknemer,int tafelId)
        {
            if(bestelling == null)
            {
                bestelling = new Bestelling(werknemer, tafelDAO.ReadByTafelNummer(tafelId), false, DateTime.Now);
                bestellingDAO.create(bestelling);
            }
            DateTime tijd = DateTime.Now;
            foreach (BestellingProduct p in producten)
            {
                p.Tijd = tijd;
                p.ProductBestelling = bestelling;
                bestellingDAO.AddProductToBestelling(p);
            }
        }   
    }
}