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
    public class BestellenKaartService
    {
        KaartDAO kaartDal = new KaartDAO();
        public List<Product> GetAllProductenFromKaart(int KaartId)
        {
            List<Product> menuKaart = new List<Product>(kaartDal.ReadAllProduct(KaartId));
            return menuKaart;

        }
        
    }
}
