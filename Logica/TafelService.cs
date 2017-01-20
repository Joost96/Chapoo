using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class TafelService
    {
        //Nieuw prijs struct en lijst bestellingproduct
        Prijzen PrijsPerProduct = new Prijzen();
        BestellingDAO dao = new BestellingDAO();
        TafelDAO tafeldao = new TafelDAO();
        public List<BestellingProduct> GetBestellingProducten(int bestellingId)
        {

            BestellingDAO bestellingDao = new BestellingDAO();

            List<BestellingProduct> bestelling = bestellingDao.ReadBestellingById(bestellingId).Producten;

            return bestelling;

        }
        //Gemaakt door mark
        public struct Prijzen
        {
            public double productprijs;
            public Category categorie;
            public double btwValue;
            public double productMetBTW;
        }
        //gemaakt door mark
        public double GetSubtotaal(int tafelId)
        {
            //Deze methode haalt aan de hand van een gegeven bestellingId een struct op met per product de prijs, de afzonderlijke BTW per product en de totaalprijs (productprijs + btw)
            double subtotaal = 0;
            List<BestellingProduct> bestelling = GetBestellingByTafelId(tafelId).Producten;

            //Voor ieder product in de lijst van de bestelling
            foreach (BestellingProduct P in bestelling)
            {
                subtotaal += P.Prijs * P.Aantal;
            }
            //Geeft een struct terug met daarin de standaard productprijs, btw waarde per product en de Totaalprijs per product.
            return subtotaal;

        }

        public Bestelling GetBestellingByTafelId(int tafelId)
        {
            BestellingDAO bestellingDAO = new BestellingDAO();
            Bestelling bestelling = bestellingDAO.ReadBestellingByTafelId(tafelId);
            return bestelling;

        }

        public void WijzigStatus(int tafelId, TafelStatus status)
        {
            tafeldao.UpdateStatus(tafelId, status);
        }


        //BTW bedrag brekenen/ Shahin
        public double GetBtwTotaal(int tafelId)
        {
            
            List<BestellingProduct> bestelling = GetBestellingByTafelId(tafelId).Producten;
            
            double totaalBtwBedrag = 0;
            foreach (BestellingProduct P in bestelling)
            {
                double btwRate = P.CategoryProduct.Btw/100.00;
                double btwBedrag = btwRate * P.Prijs;
                totaalBtwBedrag += btwBedrag * P.Aantal;
            }
            return totaalBtwBedrag;

        }
    }
}