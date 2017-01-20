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
    public partial class BetalenForm : StyleGuide.PhoneGuide
    {
        private int tafelId;
        //private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();
        //private TafelService tOverzicht = new TafelService();
        private TafelService tafel = new TafelService();
        private BetalenService betalen = new BetalenService();
        
        public BetalenForm(StyleGuide.BaseGuide vorige,Werknemer werknemer, int tafelId) :base(vorige,werknemer)
        {
            this.tafelId = tafelId;
            InitializeComponent();
            LaadTafel();
            CommentaarBox_txt.MaxLength = 200;
        }

        private void BetalenForm_Load(object sender, EventArgs e)
        {
            BetaalDrop_btn.DataSource = Enum.GetValues(typeof(BetaalMethode));
        }

        private void LaadTafel()
        {
            listViewRekOverzicht.Items.Clear();
            Bestelling bestelling = tafel.GetBestellingByTafelId(tafelId);

            foreach (BestellingProduct p in bestelling.Producten)
            {

                ListViewItem bestellingItem = new ListViewItem(p.Naam);
                bestellingItem.SubItems.Add(p.Aantal.ToString());
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listViewRekOverzicht.Items.Add(bestellingItem);

            }

            lblSubtotaal.Text = betalen.brekenSubtotaal(tafelId).ToString("C2");
            lblTotaal.Text = tafel.GetSubtotaal(tafelId).ToString("C2");
            lblBTW.Text = tafel.GetBtwTotaal(tafelId).ToString("C2");
             
            }

         private double brekenTotaalEnFooi()
         {
            fooierror_lbl.Visible = false;
            double totaal = tafel.GetSubtotaal(tafelId);
            double fooi;
            if (double.TryParse(txtBoxFooi.Text.Replace(",", "."), out fooi) == true)
            {        
                totaal += fooi;
            }
            else if (!txtBoxFooi.Text.Equals(""))
            {
                fooierror_lbl.Visible = true;
            }

            return totaal;

        }

        private void txtBoxFooi_TextChanged(object sender, EventArgs e)
        {
            lblTotaal.Text = brekenTotaalEnFooi().ToString("C2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
         {
             
         }
  
         private void betalen_btn_Click(object sender, EventArgs e)
         {
            double fooi;
             BetaalMethode betaalmethode = (BetaalMethode)BetaalDrop_btn.SelectedItem;
            if (double.TryParse(txtBoxFooi.Text, out fooi) == true)
            {
                fooi = double.Parse(txtBoxFooi.Text.Replace(",", "."));
            }           


            string commentaar = CommentaarBox_txt.Text;
            betalen.UpdateBetaalStatus(tafelId, betaalmethode, fooi, commentaar);
            vorige.Show();
            this.Close();
         }
    }
}