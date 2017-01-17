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
        KaartDAO kaartDal = new KaartDAO();
        BestellingDAO bestellingDal = new BestellingDAO();
        public List<Product> GetAllProductenFromKaart(int KaartId)
        {
            List<Product> menuKaart = new List<Product>(kaartDal.ReadAllProduct(KaartId));
            return menuKaart;
        }

        public Bestelling getBestelling(int id)
        {
            return bestellingDal.ReadBestellingById(id);
        }
        public void AddToBestelling(List<BestellingProduct> producten)
        {
            foreach (BestellingProduct p in producten)
            {
                p.Tijd = DateTime.Now;
                bestellingDal.AddProductToBestelling(p);
            }
        }  
        //item verwijderen en aantal aanpassen wordt in UI laag gedaan.    
    }
}