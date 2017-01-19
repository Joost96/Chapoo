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
                subtotaal += P.Prijs;
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
            //Deze methode haalt aan de hand van een gegeven bestellingId een struct op met per product de prijs, de afzonderlijke BTW per product en de totaalprijs (productprijs + btw)
            //List<Prijzen> Prijslijst = new List<Prijzen>();
            List<BestellingProduct> bestelling = GetBestellingByTafelId(tafelId).Producten;

            double totaalBtwBedrag = 0;
            //Voor ieder product in de lijst van de bestelling
            foreach (Product P in bestelling)
            {
                PrijsPerProduct.productprijs = P.Prijs;
                PrijsPerProduct.categorie = P.CategoryProduct;

                //Als de categorie binnen deze waardes valt is hij 6, of 12 procent.
                double btw = PrijsPerProduct.categorie.Btw;
                btw = (btw / 100 + 1);

                PrijsPerProduct.productMetBTW = (PrijsPerProduct.productprijs * btw);
                PrijsPerProduct.btwValue = (PrijsPerProduct.productMetBTW - PrijsPerProduct.productprijs);
                totaalBtwBedrag += PrijsPerProduct.btwValue;
            }
            //Geeft een struct terug met daarin de standaard productprijs, btw waarde per product en de Totaalprijs per product.
            return totaalBtwBedrag;

        }

        public double GetTotaal(int tafelId)
        {
            double totaalBedrag = GetBtwTotaal(tafelId) + GetSubtotaal(tafelId);
            return totaalBedrag; 

        }
    }

}