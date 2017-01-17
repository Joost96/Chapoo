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
        public int bestellingId;
        private int tafelId;
        public TafelForm(int tafelId)
        {
            InitializeComponent();
            this.tafelId = tafelId;
        }

        private void TafelForm_Load(object sender, EventArgs e)
        {
            // laad de kaart!
            LaadKaart();

        }

        private void LaadKaart()
        {
           
            List<BestellingProduct> bestelling = new List<BestellingProduct>();
            TafelService tafel = new TafelService();
           
            // vraagt bestellingId op

            listview_bestelling.Items.Clear();
            foreach (BestellingProduct p in tafel.GetBestellingByTafelId(tafelId)) // zet de items in de Listview
            {

                ListViewItem bestellingItem = new ListViewItem(p.Naam + p.Aantal + p.Commentaar);
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listview_bestelling.Items.Add(bestellingItem);
            }

        }

        private void bestellen_btn_Click(object sender, EventArgs e)
        {
            BestellingMenuForm form = new BestellingMenuForm(tafelId);
            form.Show();
            this.Close();
        }

        private void betalen_btn_Click(object sender, EventArgs e)
        {
            BetalenForm form = new BetalenForm(bestellingId);
        }


      
    }
}
