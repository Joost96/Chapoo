using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class LoginService
    {
        private WerknemerDAO werknemerDAO = new WerknemerDAO(); 

        public Werknemer CheckCredentials(string password, string username)
        {
            
            Werknemer werknemer = werknemerDAO.GetWerknemer(username);
            if (werknemer != null)
            {
                if (werknemer.Gebruikersnaam == username && werknemer.Wachtwoord == password)
                {
                    return werknemer;
                }

            }          
            return null;           
        }

    }
}
