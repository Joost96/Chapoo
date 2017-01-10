using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Werknemer
    {
        private int id;

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Volledigenaam { get { return Voornaam + " " + Achternaam; } }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
        public int Id { get { return id; } }

        public Werknemer(int id , string voornaam, string achternaam, string gebruikersnaam, string wachtwoord)
        {
            this.id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }
        public override string ToString()
        {
            return Volledigenaam;
        }
    }
}
