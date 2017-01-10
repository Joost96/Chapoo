using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Bestelling
    {
       private int Id;

       public int WerknemerId { get; set; }
       public int TafelId { get; set; }
       public string Commentaar { get; set; }
       public bool Betaald { get; set; }
       public BetaalMethode BetalingsMiddel { get; set; }
       public double Fooi { get; set; }
       public DateTime Datum {get;set; }
       public double TotaalBedrag { get; set; }
       public List<Product> producten { get; set; }



       public Bestelling(int id, string commentaar, bool betaald,  double fooi, DateTime datum, double totaalBedrag)
       {
           Id = id;
           Commentaar = commentaar;
           Betaald = betaald;
           Fooi = fooi;
           Datum = datum;
           TotaalBedrag = totaalBedrag;

       }

       public List<Product> AddProduct(Product product)
       {
         //  List<Product> producten = new List<Product>();
           producten.Add(product);

           return product;
          
       }
       public List<Product> RemoveProduct(Product product, int amount)
       {
           producten.Remove(product = product);

           //Only remove one, now removes all of that product

           return producten;
       }

    }
}
