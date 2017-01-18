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
    public partial class DesktopGuide : StyleGuide.BaseGuide
    {
        public DesktopGuide(Werknemer werknemer) :base(werknemer)
        {
            InitializeComponent();
            DateTime_lbl.Text = Convert.ToString(DateTime.Now);
        }

        public DesktopGuide():base()
        {
            InitializeComponent();
            DateTime_lbl.Text = Convert.ToString(DateTime.Now);
        }


    }
}
