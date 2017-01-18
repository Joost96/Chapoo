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
        public BetalenForm(StyleGuide.BaseGuide vorige, int tafelId) : base(vorige)
        {
            InitializeComponent();
            this.tafelId = tafelId;
            LaadTafel();

        }

        private void LaadTafel()
        {
            listViewRekOverzicht.Items.Clear();
            Bestelling bestelling = tafel.GetBestellingByTafelId(tafelId);
            foreach (BestellingProduct p in bestelling.Producten) // zet de items in de Listview
            {
                ListViewItem bestellingItem = new ListViewItem(p.Naam);
                bestellingItem.SubItems.Add(p.Aantal.ToString());
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listViewRekOverzicht.Items.Add(bestellingItem);

            }

            lblSubtotaal.Text = betalen.getTotaalPrijsPerBestelling(tafelId).ToString("C2");
            lblTotaal.Text = brekenTotaalEnFooi(tafelId).ToString("C2");

            // fooi toevoegen aan de bestellingProductTafel en aan de hand hier van brekenen
            // btw laten zien of niet???

        }

        private double brekenTotaalEnFooi(int tafelId)
        {
            double fooi = double.Parse(txtBoxFooi.Text);
            double totaal = betalen.getTotaalPrijsPerBestelling(tafelId);
            double totaalMetFooi = fooi + totaal;

            return totaalMetFooi;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            brekenTotaalEnFooi(tafelId);
            lblTotaal.Text = brekenTotaalEnFooi(tafelId).ToString("C2");
        }
    }
}