using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace StyleGuide
{
    public partial class PhoneGuide : StyleGuide.BaseGuide
    {
        private StyleGuide.BaseGuide vorige;
        private System.Windows.Forms.Button back_btn;
        public PhoneGuide(BaseGuide vorige, Werknemer werknemer)
            : base(werknemer)
        {
            this.vorige = vorige;
            InitializeComponent();
            this.back_btn = new System.Windows.Forms.Button();
            this.back_btn.Image = Image.FromFile("../../../images/icon/Back.png");
          
            this.back_btn.Location = new System.Drawing.Point(3, 441);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(37, 30);
            this.back_btn.TabIndex = 0;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            this.Controls.Add(this.back_btn);

           
        }


        public PhoneGuide()
        {

            InitializeComponent();

           

        }
       
        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            vorige.Show();

        }

        private void DateTime_lbl_Click(object sender, EventArgs e)
        {

        }

        private void PhoneGuide_Load(object sender, EventArgs e)
        {

        }
    }
}
