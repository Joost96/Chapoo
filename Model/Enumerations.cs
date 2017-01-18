using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public enum WerknemerRol{ bediening = 0,  keuken = 1, bar = 2 , eigenaar = 3, onbevoegd = 4};
    public enum TafelStatus { Vrij = 1, Bezet = 2, Serveren = 3 };
   public enum BetaalMethode { cash = 0, pin = 1, creditcard = 2};
   public enum BestellingStatus { Queue = 0 , Prepare = 1, Ready = 2 };

}
// besteld,  bereiding,      klaar om te serveren     geserveerd. 
//   queu      Prepare            Ready                   Serve