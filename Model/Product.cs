using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        private int Id;
        public string Category { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public int Prijs { get; set; }
        public int Voorraad { get; set; }

        public Product (int id, string naam, string omschrijving, int prijs, int voorraad)
        {
            Id = id;
            Naam = naam;
            Omschrijving = omschrijving;
            Prijs = prijs;
            Voorraad = voorraad;
        }

     

    }
}
