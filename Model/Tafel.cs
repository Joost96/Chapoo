using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        private int tafelNummer;

        public TafelStatus status { get; set; }
        public int zitplaatsen { get; set; }
        
        public Tafel (int tafelNummer, TafelStatus status, int zitplaatsen)
        {
            this.tafelNummer = tafelNummer;
            this.status = status;
            this.zitplaatsen = zitplaatsen;
        }
    }
}
