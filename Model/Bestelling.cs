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
       public List<BestellingProduct> producten { get; set; }



       public Bestelling(int id, string commentaar, bool betaald,  double fooi, DateTime datum, double totaalBedrag)
       {
           Id = id;
           Commentaar = commentaar;
           Betaald = betaald;
           Fooi = fooi;
           Datum = datum;
           TotaalBedrag = totaalBedrag;

       }

       public List<BestellingProduct> CreateProducten()
       {

           List<BestellingProduct> producten = new List<BestellingProduct>();
           return producten;
       }

       public List<BestellingProduct> AddProduct(BestellingProduct product)
       {
         //  List<Product> producten = new List<Product>();
           producten.Add(product);

           return producten;
          
       }
       public List<BestellingProduct> RemoveProduct(BestellingProduct product, int amount)
       {
           for (int i = 0; i < amount; i++)
           {
               producten.Remove(product);
           }
           //Only remove one, now removes all of that product

           return producten;
       }

    }
}
