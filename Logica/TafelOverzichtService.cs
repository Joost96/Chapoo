using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class TafelOverzichtService
    {
       private TafelDAO tafelDAO = new TafelDAO();

        

       
        public List<Tafel> GetTafels()
        {
            List<Tafel> TafelOverzicht = tafelDAO.ReadAll();
            return TafelOverzicht; 
        }
    }
}
