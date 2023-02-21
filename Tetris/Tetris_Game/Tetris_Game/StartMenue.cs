using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Tetris_Game
{
    public partial class StartMenue : Form
    {
        public StartMenue()
        {
            InitializeComponent();
        }

        private void SpielLaden(object sender, EventArgs e)
        {
            ViewGameBoard spiel = new ViewGameBoard();

            spiel.Show();
        }

        private void EinstelungenAufrufen(object sender, EventArgs e)
        {
            Einstelungen einstellen = new Einstelungen();

            einstellen.Show();
        }

        private void Steuerungbtn_Click(object sender, EventArgs e)
        {
            Steuerung steuerunganzeigen= new Steuerung();

            steuerunganzeigen.Show();
        }

        private void btnViewHighscore_Click(object sender, EventArgs e)
        {
            ViewHighscore viewHighscore = new ViewHighscore();

            viewHighscore.Show();
        }
    }
}
