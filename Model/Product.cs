using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        private int id;
        public string naam { get; set; }
        public string omschrijving { get; set; }
        public int prijs { get; set; }
        public int voorraad { get; set; }

        public Product (int id, string naam, string omschrijving, int prijs, int voorraad)
        {
            int Id = id;
            string Naam = naam;
            string Omschrijving = omschrijving;
            int Prijs = prijs;
        }

    }
}
