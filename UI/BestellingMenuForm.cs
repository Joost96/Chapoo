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
    //shahin
    public partial class BestellingMenuForm : StyleGuide.PhoneGuide
    {
        BestellenKaartService kaartService = new BestellenKaartService();
        public BestellingMenuForm()
        {
            InitializeComponent();
        }
        private void initButtons(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {

            }
        }

        private void loadDranken()
        {
            listView_dranken.Clear();
            foreach (Product p in kaartService.GetAllProductenFromKaart(3))
            {
                ListViewItem drank = new ListViewItem(p.Naam + " " + p.Omschrijving);
                drank.SubItems.Add(p.Prijs.ToString("C2"));
                listView_dranken.Items.Add(drank);

            }
        }
        private void loadLunchKaart()
        {
            listView_lunch.Clear();
            foreach (Product p in kaartService.GetAllProductenFromKaart(1))
            {
                ListViewItem lunch_item = new ListViewItem(p.Naam + " " + p.Omschrijving);
                lunch_item.SubItems.Add(p.Prijs.ToString("C2"));
                listView_lunch.Items.Add(lunch_item);

            }
        }
        private void loadDinerKaart()
        {
            listView_diner.Clear();
            foreach (Product p in kaartService.GetAllProductenFromKaart(2))
            {
                ListViewItem diner_item = new ListViewItem(p.Naam + " " + p.Omschrijving);
                diner_item.SubItems.Add(p.Prijs.ToString("C2"));
                listView_diner.Items.Add(diner_item);

            }
        }

        private void BestellingMenuForm_Load(object sender, EventArgs e)
        {
            loadDranken();
            loadLunchKaart();
            loadDinerKaart();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            loadDranken();
            loadLunchKaart();
            loadDinerKaart();
        }

        private void listView_dranken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
