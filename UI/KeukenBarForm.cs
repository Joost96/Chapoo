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
        public KeukenBarForm()
        {
            InitializeComponent();
        }
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();

        private void loadBestellingen(ListView lisoverzichtKB, Product product, int aantal, BestellingStatus status, Bestelling bestelling)
        {
            listView_keukenBar.Items.Clear();
          /*  foreach (Product p in bestellingProducten.GetAllProducten(productId))
            {
                ListViewItem item = new ListViewItem(p.Naam + p.Omschrijving);
                item.SubItems.Add(p.Prijs.ToString("C2"));
                item.SubItems.Add(p.Voorraad.ToString());
                item.Tag = p;
                lisoverzichtKB.Items.Add(item);

            }*/
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm from = new LoginForm();
            from.Show();
        }
    }
}