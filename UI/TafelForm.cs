using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Logica;

namespace UI
{
    public partial class TafelForm : StyleGuide.PhoneGuide
    {
        public TafelForm(int tafelId)
        {
            InitializeComponent();
              
        }

        private void TafelForm_Load(object sender, EventArgs e)
        {
            // Add clear() oid !
            int bestellingid;
            List<BestellingProduct> bestelling = new List<BestellingProduct>();
            TafelService tafel = new TafelService();
            tafel.GetBestellingIdByTafelId(tafelId);
            // vraagt bestellingId op
           

            foreach(BestellingProduct p in  tafel.GetBestellingProducten(bestellingid)) // zet de items in de Listview
            {
                
                ListViewItem bestellingItem = new ListViewItem(p.Naam + p.Aantal + p.Commentaar);
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listview_bestelling.Items.Add(bestellingItem);
            }


        }

      
    }
}
