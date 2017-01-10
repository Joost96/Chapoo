using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public enum WerknemerRol{ bediening = 0,  keuken = 1, bar = 2 , eigenaar = 3, onbevoegd = 4};
   public enum TafelStatus { beschikbaar = 0, gereserveerd = 1, bezet = 2}
   public enum BetaalMethode { cash = 0, pin = 1, creditcard = 2}
}
