using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class BestellingProduct : Product
    {
        int Aantal;
        Bestelling Bestelling;
        string Commentaar;
        string Tijd;
        BestellingStatus Status;

        public BestellingProduct(int id, string omschrijving, string naam, double prijs,int voorraad ,int aantal, Bestelling bestelling, string commentaar, string tijd, BestellingStatus status) 
            :base(id, naam, omschrijving,  prijs, voorraad)
        {
            Aantal = aantal;
            Bestelling = bestelling;
            Commentaar = commentaar;
            Tijd = tijd;
            Status = status;
            

        }
    }
}
