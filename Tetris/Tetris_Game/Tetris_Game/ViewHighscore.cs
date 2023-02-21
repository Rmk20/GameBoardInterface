using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_Game
{
    public partial class ViewHighscore : Form
    {
        public ViewHighscore()
        {
            InitializeComponent();
        }

        private void ViewHighscore_Load(object sender, EventArgs e)
        {
            Highscore[] highscores = Highscore.highscoreRunterladen();
            foreach (Highscore highscore in highscores)
            {
                this.dgvHighscores.Rows.Add(highscore.Name, highscore.Score);
            }
        }
    }
}
