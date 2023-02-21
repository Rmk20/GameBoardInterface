using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump_and_Run
{
    public partial class ViewMenu : Form
    {
        Thread th;
        public ViewMenu()
        {
            InitializeComponent();
        }
        
        private void btnSpielStarten_Click(object sender, EventArgs e)
        {
            FrmWechselSpiel();
        }

        private void btnMusikEinstellen_Click(object sender, EventArgs e)
        {
            FrmWechselMusik();
        }


        //Form zu ViewSpiel ändern
        private void openSpiel(object obj)
        {
            Application.Run(new ViewSpiel());
        }
        private void FrmWechselSpiel()
        {
            //this.Close();
            th = new Thread(openSpiel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        //Form zu ViewMusik ändern
        private void openMusik(object obj)
        {
            Application.Run(new ViewMusik());
        }
        private void FrmWechselMusik()
        {
            //this.Close();
            th = new Thread(openMusik);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

    }
}
