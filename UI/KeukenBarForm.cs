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
        private TafelService tafelservice = new TafelService();
        private bool locatie;


        public KeukenBarForm(Werknemer werknemer, bool locatie) :base(werknemer)
        {
            InitializeComponent();
            this.locatie = locatie;
            loadBestellingen();
        }
        

        private void loadBestellingen()
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
            this.Close();
        }

        private void bereiden_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_keukenBar.SelectedItems)
            {
                BestellingProduct product = (BestellingProduct)item.Tag;
                //Nieuwe enum dit moet bereiden
                kbService.ChangeBestellingStatus(product, BestellingStatus.Prepare);
                tafelservice.WijzigStatus(product.ProductBestelling.TafelBestelling.tafelNummer, TafelStatus.Bezet);
            }
            loadBestellingen();

        }

        private void klaar_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_keukenBar.SelectedItems)
            {
                BestellingProduct product = (BestellingProduct)item.Tag;

                //nieuwe enum dit moet ready to serve
                kbService.ChangeBestellingStatus(product, BestellingStatus.Ready);
                tafelservice.WijzigStatus(product.ProductBestelling.TafelBestelling.tafelNummer, TafelStatus.Serveren);
            }
            loadBestellingen();

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            listView_keukenBar.Controls.Clear();
            loadBestellingen();
        }
    }
}