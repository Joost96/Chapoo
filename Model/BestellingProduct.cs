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
        public DateTime Tijd { get; set; }
        public BestellingStatus Status { get; set; }
        public Bestelling ProductBestelling { get; set; }

        public BestellingProduct(int id, string omschrijving, string naam, double prijs,int voorraad ,int aantal, string commentaar, DateTime tijd, BestellingStatus status, Category category) 
            :base(id,category, naam , omschrijving, prijs, voorraad)
        {
            Aantal = aantal;
            Commentaar = commentaar;
            Tijd = tijd;
            Status = status;
        }
        public BestellingProduct(Product product , int aantal, BestellingStatus status , Bestelling bestelling)
    : base(product.Id, product.CategoryProduct, product.Naam, product.Omschrijving, product.Prijs, product.Voorraad)
        {
            Aantal = aantal;
            Status = status;
            ProductBestelling = bestelling;
        }

        public BestellingProduct(int id, string naam, int aantal, string commentaar, DateTime tijd, BestellingStatus status) : base(id, naam)
        {
            Aantal = aantal;
            Commentaar = commentaar;
            Tijd = tijd;
            Status = status;
        }
    }
}
