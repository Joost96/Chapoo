﻿using System;
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
    public partial class OverzichtForm : StyleGuide.PhoneGuide
    {
        public OverzichtForm(StyleGuide.BaseGuide vorige, Werknemer werknemer) :base(vorige, werknemer)
        {
            InitializeComponent();
            TafelsLaden();
        }

        private void OverzichtForm_Load(object sender, EventArgs e)
        {
            //TafelsLaden();
        }

        private void TafelsLaden()
        {
            TafelOverzichtService tOverzichtServ = new TafelOverzichtService();
            foreach (Tafel tafel in tOverzichtServ.GetTafels())
            {
                Button btn = new Button();
                btn.Text = "Tafel " + tafel.tafelNummer.ToString() + ' ' + tafel.status.ToString();
                btn.Size = new Size(120, 60);
                btn.Margin = new Padding(6);
                if (tafel.status == TafelStatus.Vrij)
                {
                    btn.BackColor = Color.Gray;
                }

                else if (tafel.status == TafelStatus.Gereserveerd)
                {
                    btn.BackColor = Color.Orange;
                }

                else if (tafel.status == TafelStatus.Bezet)
                {
                    btn.BackColor = Color.Green;
                }

                //btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);


            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            
            TafelsLaden();
        }
    }
}
