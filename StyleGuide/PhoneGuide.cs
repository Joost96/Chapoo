using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StyleGuide
{
    public partial class PhoneGuide : StyleGuide.BaseGuide
    {
        private StyleGuide.BaseGuide vorige;
        public PhoneGuide()
        {
        
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();         
            vorige.Show();
            
        }
    }
}
