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
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();
        private TafelService tOverzicht = new TafelService();
        private TafelService tafel = new TafelService();
        private BetalenService betalen = new BetalenService();
        public BetalenForm(StyleGuide.BaseGuide vorige,Werknemer werknemer, int tafelId) :base(vorige,werknemer)
        {
            this.tafelId = tafelId;
            InitializeComponent();
            LaadTafel();
        }

        private void LaadTafel()
        {


            TafelService tafel = new TafelService();

            // vraagt bestellingId op

            listViewRekOverzicht.Items.Clear();
            Bestelling bestelling = tafel.GetBestellingByTafelId(tafelId);
            foreach (BestellingProduct p in bestelling.Producten) // zet de items in de Listview
            {

                ListViewItem bestellingItem = new ListViewItem(p.Naam);
                bestellingItem.SubItems.Add(p.Aantal.ToString());
                bestellingItem.SubItems.Add(p.Commentaar);
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listViewRekOverzicht.Items.Add(bestellingItem);

            }
            lblSubtotaal.Text = betalen.getTotaalPrijsPerBestelling(tafelId).ToString("C2");
            lblTotaal.Text = brekenTotaalEnFooi().ToString("C2");
            
                        // fooi toevoegen aan de bestellingProductTafel en aan de hand hier van brekenen
                        // btw laten zien of niet???
             
            }

         private double brekenTotaalEnFooi()
         {
            fooierror_lbl.Visible = false;
            double totaal = betalen.getTotaalPrijsPerBestelling(tafelId);
            double fooi;
            if (double.TryParse(txtBoxFooi.Text, out fooi) == true)
            {        
                totaal += fooi;
            }

            else
            {
                fooierror_lbl.Visible = true;
            }

            return totaal;

        }
 
         private void pictureBox1_Click(object sender, EventArgs e)
         {
             
         }

private void BetalenForm_Load(object sender, EventArgs e)
         {
             BetaalDrop_btn.DataSource = Enum.GetValues(typeof(BetaalMethode));
         }
  
         private void betalen_btn_Click(object sender, EventArgs e)
         {
            double fooi;
             BetaalMethode betaalmethode = (BetaalMethode)BetaalDrop_btn.SelectedItem;
            if (double.TryParse(txtBoxFooi.Text, out fooi) == true)
            {
                fooi = double.Parse(txtBoxFooi.Text);
            }
            


            string commentaar = CommentaarBox_txt.Text;
             betalen.UpdateBetaalStatus(tafelId, betaalmethode, fooi, commentaar);
            vorige.Show();
            this.Close();
         }

        private void txtBoxFooi_TextChanged(object sender, EventArgs e)
        {
            lblTotaal.Text = brekenTotaalEnFooi().ToString("C2");
        }
    }
}


