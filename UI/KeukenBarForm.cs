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
    public partial class KeukenBarForm : StyleGuide.DesktopGuide
    {
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();
        private KeukenBarService kbService = new KeukenBarService();
        public KeukenBarForm(StyleGuide.BaseGuide vorigeForm, bool locatie)
        {
            InitializeComponent();
            loadBestellingen(locatie);
            
        }
        

        private void loadBestellingen(bool locatie)
        {
            listView_keukenBar.Items.Clear();
            bestellingProducten = kbService.GetOpenBestellingen(locatie);
            foreach (BestellingProduct p in bestellingProducten)
            {
                ListViewItem item = new ListViewItem(p.Naam);
                item.SubItems.Add(p.Aantal.ToString());
                item.SubItems.Add(p.Status.ToString());
                item.SubItems.Add(p.ProductBestelling.TafelBestelling.tafelNummer.ToString());
                item.SubItems.Add(p.Commentaar.ToString());
                item.SubItems.Add(p.Tijd.ToString("H:mm"));
                item.Tag = p;
                listView_keukenBar.Items.Add(item);

            }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm from = new LoginForm();
            from.Show();
        }
    }
}