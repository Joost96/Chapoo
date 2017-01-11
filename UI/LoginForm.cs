using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;
using System.Diagnostics;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string userName = userName_tb.Text;
            string passWord = passWord_tb.Text;

            LoginService login = new LoginService();
            WerknemerRol rolVanWerknemer = login.CheckCredentials(passWord, userName);
            if (rolVanWerknemer == WerknemerRol.bar)
            {

            }

            else if (rolVanWerknemer == WerknemerRol.bediening)
            {
                Hide();
                OverzichtForm overzicht = new OverzichtForm();
                overzicht.Show();
            }

            else if (rolVanWerknemer == WerknemerRol.eigenaar)
            {
                // krijgt scherm under construction
                Hide();
                EigenaarForm from = new EigenaarForm();
                from.Show();
                // hide maar nog niet close ???
            }

            else if (rolVanWerknemer == WerknemerRol.keuken)
            {
                Hide();
                KeukenForm from = new KeukenForm();
                from.Show();
            }

            else if (rolVanWerknemer == WerknemerRol.onbevoegd)
            {

            }

            
        }

        private void passWord_lbl_Click(object sender, EventArgs e)
        {

        }

        private void userName_lbl_Click(object sender, EventArgs e)
        {

        }

        private void passWord_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
