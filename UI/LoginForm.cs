using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Logica;
using System.Diagnostics;

namespace UI
{
    public partial class LoginForm : StyleGuide.PhoneGuide
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string userName = userName_tb.Text;
            string passWord = passWord_tb.Text;
            LoginService login = new LoginService();
            werknemer = login.CheckCredentials(passWord, userName);
                        
            onbevoegd_lbl.Visible = false;
            if (werknemer == null)
            {
                onbevoegd_lbl.Visible = true;
            }
            else if (werknemer.rol == WerknemerRol.bar)
            {
                Hide();
                KeukenBarForm form = new KeukenBarForm(werknemer, false);
                form.Show();
            }

            else if (werknemer.rol == WerknemerRol.bediening)
            {
                Hide();
                OverzichtForm overzicht = new OverzichtForm(this, werknemer);
                overzicht.Show();
            }

            else if (werknemer.rol == WerknemerRol.eigenaar)
            {

                Hide();
                EigenaarForm form = new EigenaarForm(werknemer);
                form.Show();
                // hide maar nog niet close ???
            }

            else if (werknemer.rol == WerknemerRol.keuken)
            {
                Hide();
                KeukenBarForm form = new KeukenBarForm(werknemer, true);
                form.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
