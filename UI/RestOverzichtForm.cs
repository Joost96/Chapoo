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
    public partial class RestOverzichtForm : StyleGuide.PhoneGuide
    {
        public RestOverzichtForm(Werknemer werknemer) :base(werknemer)
        {
            InitializeComponent();
            TafelsLaden();
            CreateTimer();
        }

        private void OverzichtForm_Load(object sender, EventArgs e)
        {
            //TafelsLaden();
        }
        private void CreateTimer()
        {
           Timer lilTimer = new Timer();
           lilTimer.Interval =10000;
           lilTimer.Enabled = true;
           lilTimer.Tick += new EventHandler(MyLittleTimer);
           lilTimer.Start();

        }
        private void MyLittleTimer(Object sender, EventArgs e)
        {
            TafelsLaden();
        }
        private void TafelsLaden()
        {
            flowLayoutPanel1.Controls.Clear();
            TafelOverzichtService tOverzichtServ = new TafelOverzichtService();
            foreach (Tafel tafel in tOverzichtServ.GetTafels())
            {
                Button btn = new Button();
                btn.Name = tafel.tafelNummer.ToString();
                btn.Text = "Tafel " + tafel.tafelNummer.ToString() + ' ' + tafel.status.ToString();
                btn.Size = new Size(160, 54);
                btn.Margin = new Padding(3);
                btn.FlatStyle = FlatStyle.Flat;
                if (tafel.status == TafelStatus.Vrij)
                {
                    btn.BackColor = Color.Gray;
                }

                else if (tafel.status == TafelStatus.Bezet)
                {
                    btn.BackColor = Color.Orange;
                }

                else if (tafel.status == TafelStatus.Serveren)
                {
                    btn.BackColor = Color.Green;
                }

                btn.Click += new EventHandler(tafel_btn_Click);
                flowLayoutPanel1.Controls.Add(btn);


            }
        }
        private void tafel_btn_Click(object sender,EventArgs e)
        {
            this.Hide();
            int tafelNr = Int32.Parse(((Button)sender).Name);
            StyleGuide.BaseGuide form = new TafelForm(this,werknemer,tafelNr);
            form.Show();
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
