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
        public List<BestellingProduct> getBestellingProducten(int bestellingId)
        {
            List<BestellingProduct> bestelling = BestellingProductDAO.ReadAllFromBestellingProducten(bestellingId);

            return bestelling;

        }
        //Gemaakt door mark
        public struct Prijzen
        {
            public double productprijs;
            public string categorie;
            public double btwValue;
            public double productMetBTW;
        }
        //gemaakt door mark
        public Prijzen GetPrijzen(int bestellingId)
        {
            //Deze methode haalt aan de hand van een gegeven bestellingId een struct op met per product de prijs, de afzonderlijke BTW per product en de totaalprijs (productprijs + btw)

            //Nieuw prijs struct en lijst bestellingproduct
            Prijzen prijs = new Prijzen();
            List<BestellingProduct> bestelling = getBestellingProducten(bestellingId);

            //Voor ieder product in de lijst van de bestelling
            foreach (Product P in bestelling)
            {
                prijs.productprijs = P.Prijs;
                prijs.categorie = P.Category;
                
                //Als de categorie binnen deze waardes valt is hij 6, of 12 procent.
                int numCat = Int32.Parse(prijs.categorie);
                if(numCat <= 8 || numCat == 12)
                {
                    double btw = 1.06;
                    prijs.productMetBTW = (prijs.productprijs * btw) ;
                    prijs.btwValue = (prijs.productMetBTW - prijs.productprijs);
                }
                else if (numCat >= 9 && numCat <= 11 )
                {
                    double btw = 1.21;
                    prijs.productMetBTW = (prijs.productprijs * btw);
                }



                

                
            }
            //Geeft een struct terug met daarin de standaard productprijs, btw waarde per product en de Totaalprijs per product.
            return prijs;

        }

    }
}

