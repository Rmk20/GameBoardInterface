using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump_and_Run
{
    public partial class ViewHighscore : Form
    {
        public ViewHighscore()
        {
            InitializeComponent();

        }

        public ViewHighscore(int score)
        {
            InitializeComponent();
            lblHighscore.Text = "Dein Score war: " + score;
        }







    }
}
