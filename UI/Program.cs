﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BestellingMenuForm(new Model.Werknemer(1,"","","","",Model.WerknemerRol.bediening),2));
            // Application.Run(new KeukenBarForm(new Model.Werknemer(2, "", "", "", "", Model.WerknemerRol.bar),false));
        }
    }
}