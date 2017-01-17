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
        public List<BestellingProduct> GetBestellingProducten(int bestellingId)
        {
            List<BestellingProduct> bestelling = BestellingDAO.ReadAllFromBestellingProducten(bestellingId);

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
        public List<Prijzen> GetPrijzen(int bestellingId)
        {
            //Deze methode haalt aan de hand van een gegeven bestellingId een struct op met per product de prijs, de afzonderlijke BTW per product en de totaalprijs (productprijs + btw)
            List<Prijzen> Prijslijst = new List<Prijzen>();
            //Nieuw prijs struct en lijst bestellingproduct
            Prijzen PrijsPerProduct = new Prijzen();
            List<BestellingProduct> bestelling = GetBestellingProducten(bestellingId);
            

            //Voor ieder product in de lijst van de bestelling
            foreach (Product P in bestelling)
            {
                PrijsPerProduct.productprijs = P.Prijs;
                PrijsPerProduct.categorie = P.CategoryProduct;
                
                //Als de categorie binnen deze waardes valt is hij 6, of 12 procent.
                int numCat = PrijsPerProduct.categorie.Btw;
                if(numCat <= 8 || numCat == 12)
                {
                    double btw = 1.06;
                    PrijsPerProduct.productMetBTW = (PrijsPerProduct.productprijs * btw) ;
                    PrijsPerProduct.btwValue = (PrijsPerProduct.productMetBTW - PrijsPerProduct.productprijs);

                }
                else if (numCat >= 9 && numCat <= 11 )
                {
                    double btw = 1.21;
                    PrijsPerProduct.productMetBTW = (PrijsPerProduct.productprijs * btw);
                }

                Prijslijst.Add(PrijsPerProduct);

                

                
            }
            //Geeft een struct terug met daarin de standaard productprijs, btw waarde per product en de Totaalprijs per product.
            return Prijslijst;

        }

    }
}

