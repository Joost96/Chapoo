using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace StyleGuide
{
    public partial class BaseGuide : Form
    {
        protected Werknemer werknemer;
        public BaseGuide(Werknemer werknemer)
        {
            this.werknemer = werknemer;
            InitializeComponent();

            CreateTimer2();
            AddWerknemerToHeader(werknemer); // geeft de huidige tijd + de werknemer weer in de header, als de werknemer is meegegeven in het form
        }
        public BaseGuide()
        {
            InitializeComponent();

            CreateTimer(); //maakt de timer aan
            GetCurrentTime(); // geeft de huidige tijd weer in de header
        }
        private void AddWerknemerToHeader(Werknemer werknemer)
        {
            string dateTime = DateTime.Now.ToShortTimeString();
            this.Text = string.Format("Chapoo - {0} - {1} ", werknemer, dateTime); // zet deze tekst in de header!
        }


        private void CreateTimer() 
        {
            Timer aTimer = new Timer();

            aTimer.Interval = 10000; //zet de timer op 10s

            aTimer.Enabled = true; 
            aTimer.Tick += new EventHandler(MyLittleTimer); // zet dit event vast aan de timer
            aTimer.Start();
        }

        private void CreateTimer2() //zelfde methode als hierboven, alleen deze gebruikt later een andere methode
        {
            Timer aTimer = new Timer();

            aTimer.Interval = 10000;

            aTimer.Enabled = true;
            aTimer.Tick += new EventHandler(MyLittleTimer2); 
            aTimer.Start();
        }

        private void MyLittleTimer2(Object sender, EventArgs e)
        {
            AddWerknemerToHeader(werknemer);

        }
        private void MyLittleTimer(Object sender, EventArgs e)
        {
            GetCurrentTime();

        }

        private void GetCurrentTime()
        {
            string dateTime = DateTime.Now.ToShortTimeString();
            this.Text = string.Format("Chapoo {0}", dateTime); // zet de tekst in de header

        }
    }
}
