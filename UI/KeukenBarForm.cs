using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class KeukenBarForm : StyleGuide.DesktopGuide
    {
        public KeukenBarForm()
        {
            InitializeComponent();
        }

        private void loadBestellingen()
        {
            
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm from = new LoginForm();
            from.Show();
        }
    }
}