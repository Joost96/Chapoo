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
    public partial class OverzichtForm : Form
    {
        public OverzichtForm()
        {
            InitializeComponent();
        }

        private void beschikbaar_lbl_Click(object sender, EventArgs e)
        {

        }

        private void gereserveerd_lbl_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm from = new LoginForm();
            from.Show();
        }
    }
}
