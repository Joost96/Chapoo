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
    public partial class TafelForm : StyleGuide.PhoneGuide
    {
        private TafelService tafelService = new TafelService();

        private int tafelId;
        private Bestelling bestelling;
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();

        public TafelForm(StyleGuide.BaseGuide vorige, Werknemer werknemer, int tafelId)
            : base(vorige, werknemer)
        {
            InitializeComponent();
            this.tafelId = tafelId;
        }

        private void TafelForm_Load(object sender, EventArgs e)
        {
            // laad de kaart!
            LaadKaart();
            CreateTimer();

        }
        private void CreateTimer()
        {
            Timer littleTimer = new Timer();
            littleTimer.Interval = 10000;
            littleTimer.Enabled = true;
            littleTimer.Tick += new EventHandler(MyLittleTimer);
            littleTimer.Start();
        }
        private void MyLittleTimer(Object sender, EventArgs e)
        {
            LaadKaart();
        }

        public void LaadKaart()
        {
            TafelService tafel = new TafelService();

            // vraagt de bestelling op aan de hand van het Tafel Id

            listview_bestelling.Items.Clear();

            this.bestelling = tafel.GetBestellingByTafelId(tafelId);
               
            if(bestelling != null)
            foreach (BestellingProduct p in bestelling.Producten) // zet de items in de Listview
            {
                ListViewItem lvItem = new ListViewItem(p.Naam);
                lvItem.SubItems.Add(p.Aantal.ToString());
                lvItem.SubItems.Add(p.Commentaar);
                lvItem.SubItems.Add(p.Prijs.ToString("C2"));
                lvItem.SubItems.Add(p.Status.ToString());
                lvItem.Tag = p;
                listview_bestelling.Items.Add(lvItem);
            }

        }

        private void bestellen_btn_Click(object sender, EventArgs e)
        {
            // verwijst door naar de Bestel kaart
            warning2_lbl.Visible = false;
            BestellingMenuForm form = new BestellingMenuForm(this, werknemer, tafelId);
            this.Hide();        
            form.Show();
            
        }

        private void betalen_btn_Click(object sender, EventArgs e)
        {
            if (bestelling != null)
            {
                BetalenForm form = new BetalenForm(this, werknemer, tafelId);
                this.Hide();
                form.Show();
            }
            else
            warning2_lbl.Visible = true;
        }

        private void serveer_btn_Click(object sender, EventArgs e)
        {
           
            KeukenBarService keukenBar = new KeukenBarService();
            
            foreach (ListViewItem item in listview_bestelling.SelectedItems)
            {
                BestellingProduct product = (BestellingProduct)item.Tag;
                if (product.Status == BestellingStatus.Ready) // kijkt of bestelling status wel status Ready heeft!
                {
                    warning_lbl.Visible = false;
                    keukenBar.ChangeBestellingStatus(product, BestellingStatus.Served);                  
                }
                else 
                {
                    warning_lbl.Visible = true;                
                  
                }
            }
            bool AllServerd = true;
            foreach (ListViewItem item in listview_bestelling.Items)
            {
                AllServerd = ((BestellingProduct)item.Tag).Status != BestellingStatus.Ready;
            }
            if(AllServerd)
            {
                tafelService.WijzigStatus(tafelId, TafelStatus.Bezet);
            }
            LaadKaart();
          
        }
    }
}
