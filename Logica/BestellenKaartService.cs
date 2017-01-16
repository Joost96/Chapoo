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

        public void AddToBestelling(List<BestellingProduct> productenOpLijst)
        {
            foreach (BestellingProduct p in productenOpLijst)
            {
                bestellingDal.AddProduct(p);
            }
        }  
        
        //item verwijderen en aantal aanpassen wordt in UI laag gedaan.    
    }
}