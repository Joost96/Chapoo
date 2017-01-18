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
   
        private int tafelId;
        private Bestelling bestelling;
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();

        public TafelForm(StyleGuide.BaseGuide vorige, Werknemer werknemer, int tafelId)
            : base(vorige, werknemer)
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
            this.bestelling = tafel.GetBestellingByTafelId(tafelId);
            foreach (BestellingProduct p in bestelling.Producten) // zet de items in de Listview
            {
                ListViewItem lvItem = new ListViewItem(p.Naam);
                lvItem.SubItems.Add(p.Aantal.ToString());
                lvItem.SubItems.Add(p.Commentaar);
                lvItem.SubItems.Add(p.Prijs.ToString("C2"));
                listview_bestelling.Items.Add(lvItem);
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
            BetalenForm form = new BetalenForm(this, werknemer, tafelId);
            form.Show();
            this.Close();
        }

        private void serveer_btn_Click(object sender, EventArgs e)
        {
           
            KeukenBarService keukenBar = new KeukenBarService();
            
            foreach (ListViewItem item in listview_bestelling.SelectedItems)
            {
                Product product = (Product)item.Tag;
                BestellingProduct bestellingProduct = bestellingProducten.Find(bp => bp.Id == product.Id);
                if (bestellingProduct != null)
                {
                    bestellingProduct.Aantal++;
                }
                else
                {
                    bestellingProducten.Add(new BestellingProduct(product, 1, BestellingStatus.Queue));
                }
            }
            foreach(BestellingProduct product in bestelling.Producten)
            { 
            keukenBar.ChangeBestellingStatus( product,BestellingStatus.Served);
            }
        }
    }
}
