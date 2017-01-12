using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category
    {
        private int Id;

        public string Naam { get; set; }
        public int Btw {get;set;}
        public Kaart KaartCat { get; set; }
        public List<Product> Producten { get; set; }

        public Category(int btw, int id, string naam, Kaart kaart)
        {
            Id = id;
            Btw = btw;
            Naam = naam;
            KaartCat = kaart;
        }


    }
}
