using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class EigenaarForm : StyleGuide.DesktopGuide
    {
        public EigenaarForm(Werknemer werknemer) :base(werknemer)
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm from = new LoginForm();
            from.Show();
            this.Close();
        }
    }
}
