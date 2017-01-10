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

                tafelDAO.update(tafel);

                if (tafelDAO.update = false)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
