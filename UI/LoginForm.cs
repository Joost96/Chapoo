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
            WerknemerRol rolVanWerknemer = login.CheckCredentials(passWord, userName);
            Debug.WriteLine(rolVanWerknemer);
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
    }
}
