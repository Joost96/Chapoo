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
        public BetalenForm(StyleGuide.BaseGuide vorige, int tafelId) : base(vorige)
        {
            InitializeComponent();
            this.tafelId = tafelId;
            LaadTafel();

        }

        private void LaadTafel()
        {
            TafelService tafel = new TafelService();
            BetalenService betalen = new BetalenService();

            listViewRekOverzicht.Items.Clear();
            Bestelling bestelling = tafel.GetBestellingByTafelId(tafelId);
            foreach (BestellingProduct p in bestelling.Producten) // zet de items in de Listview
            {
                ListViewItem bestellingItem = new ListViewItem(p.Naam);
                bestellingItem.SubItems.Add(p.Aantal.ToString());
                bestellingItem.SubItems.Add(p.Prijs.ToString("C2"));
                listViewRekOverzicht.Items.Add(bestellingItem);

            }

            lblTotaal.Text = Convert.ToString(betalen.getTotaalPrijsPerBestelling(tafelId));

            // fooi toevoegen aan de bestellingProductTafel en aan de hand hier van brekenen
            // btw laten zien of niet???

        }
    }
}