using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StyleGuide
{
    public partial class DesktopGuide : StyleGuide.BaseGuide
    {
        public DesktopGuide()
        {
            InitializeComponent();
            DateTime_lbl.Text = Convert.ToString(DateTime.Now);
        }
    }
}
