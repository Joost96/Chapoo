using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
           try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.ToString());
                Application.Exit();
                MessageBox.Show("Er kan geen verbinding met de database worden gemaakt!\n " +
                    "Probeer dit opnieuw of neem contact op met de systeem beheerder",
                    "Verbindingsproblemen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            } 
        }
    }
}