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

        public TafelForm(StyleGuide.BaseGuide vorige,Werknemer werknemer, int tafelId) :base(vorige,werknemer)
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
           
            
            TafelService tafel = new TafelService();
           
            // vraagt bestellingId op

            listview_bestelling.Items.Clear();
            Bestelling bestelling = tafel.GetBestellingByTafelId(tafelId);
            foreach (BestellingProduct p in bestelling.Producten ) // zet de items in de Listview
            {

                ListViewItem bestellingItem = new ListViewItem(p.Naam);
                bestellingItem.SubItems.Add(p.Aantal.ToString());
                bestellingItem.SubItems.Add(p.Commentaar);
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listview_bestelling.Items.Add(bestellingItem);
            }

        } 

        private void bestellen_btn_Click(object sender, EventArgs e)
        {
            // verwijst door naar de Bestel kaart
            BestellingMenuForm form = new BestellingMenuForm(this, werknemer, tafelId);
            form.Show();
            this.Close();
        }

        private void betalen_btn_Click(object sender, EventArgs e)
        {
            //BetalenForm form = new BetalenForm(bestellingId);
            //form.Show();
            this.Close();
        }
    }
}
