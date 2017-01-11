using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TafelOverzichtForm : Form
    {
        public TafelOverzichtForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BestellingMenuForm bestel = new BestellingMenuForm();
            bestel.Show();
            this.Close();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            OverzichtForm home = new OverzichtForm();
            home.Show();
            this.Close();
        }
    }
}
