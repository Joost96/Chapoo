using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public Category CategoryProduct { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public double Prijs { get; set; }
        public int Voorraad { get; set; }

        public Product (int id, Category categoryProduct, string naam, string omschrijving, double prijs, int voorraad)
        {
            Id = id;
            CategoryProduct = categoryProduct
            Naam = naam;
            Omschrijving = omschrijving;
            Prijs = prijs;
            Voorraad = voorraad;
        }

        public Product(string naam, double prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

     

    }
}

