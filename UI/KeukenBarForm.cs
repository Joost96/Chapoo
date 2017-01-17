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
        public KeukenBarForm(bool locatie)
        {
            InitializeComponent();
            loadBestellingen(locatie);
            
        }
        private List<BestellingProduct> bestellingProducten = new List<BestellingProduct>();

        private void loadBestellingen(bool locatie)
        {
            listView_keukenBar.Items.Clear();
            if (locatie == true)
            { }
            else { }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm from = new LoginForm();
            from.Show();
        }
    }
}