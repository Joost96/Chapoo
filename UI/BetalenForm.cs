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
        public BetalenForm(StyleGuide.BaseGuide vorige, int bestellingId) : base(vorige)
        {
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
                
            }

        }

    }
    }


