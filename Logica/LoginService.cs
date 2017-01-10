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

        public WerknemerRol CheckCredentials(string password, string username)
        {
            
            Werknemer werkNemer = werknemerDAO.GetWerknemer(username);
            if (werkNemer != null)
            {
                if (werkNemer.Gebruikersnaam == username && werkNemer.Wachtwoord == password)
                {
                    return werkNemer.rol;
                }

            }          
                return (WerknemerRol)4;           
        }

    }
}
