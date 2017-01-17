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
        private BestellenKaartService kaartService = new BestellenKaartService();
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();
        private BestellingProduct editProduct;

        private Bestelling bestelling;
        public BestellingMenuForm(int id)
        {
            InitializeComponent();
            bestelling = kaartService.getBestelling(id);
        }

        private void loadKaart(ListView listview , int kaartId)
        {
            listview.Items.Clear();
            foreach (Product p in kaartService.GetAllProductenFromKaart(kaartId))
            {
                ListViewItem item = new ListViewItem(p.Naam + " " + p.Omschrijving);
                item.SubItems.Add(p.Prijs.ToString("C2"));
                item.SubItems.Add(p.Voorraad.ToString());
                item.Tag = p;
                listview.Items.Add(item);

            }
        }
        private void loadBestellingen()
        {
            List<int> selectedIds = new List<int>();
            foreach(ListViewItem item in listviewBestelling.SelectedItems)
            {
                if(item.Selected)
                {
                    selectedIds.Add(((Product)item.Tag).Id);
                }
            }
            listviewBestelling.Items.Clear();
            foreach (BestellingProduct bp in bestellingProducten)
            {
                ListViewItem item = new ListViewItem(bp.Naam);
                item.SubItems.Add(bp.Prijs.ToString("C2"));
                item.SubItems.Add(bp.Aantal.ToString());
                item.SubItems.Add(bp.Commentaar);
                item.Tag = bp;
                if(selectedIds.Contains(bp.Id))
                {
                    item.Selected = true;
                }
                listviewBestelling.Items.Add(item);

            }
            
        }
        private void addProducten(ListView listview)
        {
            foreach (ListViewItem item in listview.SelectedItems)
            {
                Product product = (Product)item.Tag;
                BestellingProduct bestellingProduct = bestellingProducten.Find(bp => bp.Id == product.Id);
                if (bestellingProduct != null)
                {
                    bestellingProduct.Aantal++;
                }
                else
                {
                    bestellingProducten.Add(new BestellingProduct(product, 1, BestellingStatus.Queue , bestelling));
                }
            }
            loadBestellingen();
        }
        private void removeProducten()
        {
            foreach (ListViewItem item in listviewBestelling.SelectedItems)
            {
                BestellingProduct betsellingProductTag = (BestellingProduct)item.Tag;
                BestellingProduct bestellingProduct = bestellingProducten.Find(bp => bp.Id == betsellingProductTag.Id);
                if (bestellingProduct != null)
                {
                    if ((--bestellingProduct.Aantal) == 0)
                    {
                        bestellingProducten.Remove(bestellingProduct);
                    }
                }
            }
            loadBestellingen();
        }

        private void BestellingMenuForm_Load(object sender, EventArgs e)
        {
            loadKaart(listViewLunch, 1);
            loadKaart(listViewDiner, 2);
            loadKaart(listViewDrank , 3);
        }

        private void listView_dranken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDrankAdd_Click(object sender, EventArgs e)
        {
            addProducten(listViewDrank);
        }

        private void btnLunchAdd_Click(object sender, EventArgs e)
        {
            addProducten(listViewLunch);
        }

        private void btnDinerAdd_Click(object sender, EventArgs e)
        {
            addProducten(listViewDiner);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeProducten();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editProduct.Commentaar = txtBoxComment.Text;
            panelEdit.Visible = false;
        }

        private void bewerken_btn_Click(object sender, EventArgs e)
        {
            BestellingProduct betsellingProductTag = (BestellingProduct)listviewBestelling.SelectedItems[0].Tag;
            BestellingProduct bestellingProduct = bestellingProducten.Find(bp => bp.Id == betsellingProductTag.Id);
            if (bestellingProduct != null)
            {
                editProduct = bestellingProduct;
                panelEdit.Visible = true;
            }
        }

        private void bestellen_btn_Click(object sender, EventArgs e)
        {
            listviewBestelling.Items.Clear();
            kaartService.AddToBestelling(bestellingProducten);
        }
    }
}
