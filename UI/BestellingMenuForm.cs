using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;

namespace UI
{
    public partial class BestellingMenuForm : Form
    {
        public BestellingMenuForm()
        {
            InitializeComponent();
        }

        private void drinkenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drinken_tab_Click(object sender, EventArgs e)
        {
            KaartDAO.Read();
            foreach (Product p in menu)
        }
    }
}
