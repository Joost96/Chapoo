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

        private void OverzichtForm_Load(object sender, EventArgs e)
        {
            foreach (Tafel tafel in TafelOverzichtService.GetTafels())
            {
                Button btn = new Button();
                btn.Text = tafel.tafelNummer.ToString();
                btn.Size = new Size(87, 40);
                btn.Margin = new Padding(6);
                if (tafel.status == TafelStatus.beschikbaar)
                {
                    btn.BackColor = Color.Gray;
                }

                else if (tafel.status == TafelStatus.gereserveerd)
                {
                    btn.BackColor = Color.Orange;
                }

                else if (tafel.status == TafelStatus.bezet)
                {
                    btn.BackColor = Color.Green;
                }

                //btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);


            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
