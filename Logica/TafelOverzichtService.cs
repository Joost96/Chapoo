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

        public bool VeranderStatus(Tafel tafel, TafelStatus newStatus)
        {
            try
            {
                tafel.status = newStatus;

                TafelDAO.Update(tafel);

                if (TafelDAO.Update(tafel) == false)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        // delete static
        public static List<Tafel> GetTafels()
        {
            List<Tafel> TafelOverzicht = TafelDAO.ReadAll();
            // TafelDAO.ReadAll();

            // eventjes geen idee!
            return TafelOverzicht; 
        }
    }
}
