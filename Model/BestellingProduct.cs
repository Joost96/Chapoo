using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestellingProduct : Product
    {
        public int Aantal { get; set; }
        public string Commentaar { get; set; }
        public string Tijd { get; set; }
        public BestellingStatus Status { get; set; }

        public BestellingProduct(int id, string omschrijving, string naam, double prijs,int voorraad ,int aantal, string commentaar, string tijd, BestellingStatus status) 
            :base(id, omschrijving, naam, prijs, voorraad)
        {
            Aantal = aantal;
            Commentaar = commentaar;
            Tijd = tijd;
            Status = status;
            

        }
    }
}
