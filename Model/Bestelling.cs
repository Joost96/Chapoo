using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Bestelling
    {
      
       public int Id { get; private set; }
       public Werknemer Bediening { get; set; }
       public Tafel TafelBestelling { get; set; }
       public string Commentaar { get; set; }
       public bool Betaald { get; set; }
       public BetaalMethode BetalingsMiddel { get; set; }
       public double Fooi { get; set; }
       public DateTime Datum {get;set; }
       public double TotaalBedrag { get; set; }
       public List<BestellingProduct> Producten { get; set; }



       public Bestelling(int id,Werknemer bediening, Tafel tafelBestelling, string commentaar, bool betaald, BetaalMethode betalingsMiddel,  double fooi, DateTime datum, double totaalBedrag)
       {
           Id = id;
           Bediening = bediening;
            TafelBestelling = tafelBestelling;
           Commentaar = commentaar;
           Betaald = betaald;
            BetalingsMiddel = betalingsMiddel;
           Fooi = fooi;
           Datum = datum;
           TotaalBedrag = totaalBedrag;
            Producten = new List<BestellingProduct>();
       }
        public Bestelling(Werknemer bediening, Tafel tafelBestelling, bool betaald, DateTime datum)
        {
            Bediening = bediening;
            TafelBestelling = tafelBestelling;
            Betaald = betaald;
            Datum = datum;
            Producten = new List<BestellingProduct>();
        }
        public Bestelling(int id ,Werknemer bediening, Tafel tafelBestelling, bool betaald, DateTime datum)
        {
            Id = id;
            Bediening = bediening;
            TafelBestelling = tafelBestelling;
            Betaald = betaald;
            Datum = datum;
            Producten = new List<BestellingProduct>();
        }
        public Bestelling(int id)
        {
            Id = id;
        }

       public List<BestellingProduct> AddProduct(BestellingProduct product)
       {
           Producten.Add(product);

           return Producten;
          
       }
       public List<BestellingProduct> RemoveProduct(BestellingProduct product, int amount)
       {
           for (int i = 0; i < amount; i++)
           {
               Producten.Remove(product);
           }
           //Only remove one, now removes all of that product

           return Producten;
       }

    }
}
