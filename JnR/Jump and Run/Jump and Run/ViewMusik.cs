using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jump_and_Run
{
    public partial class ViewMusik : Form
    {
        private SoundPlayer soundplayer;
        public ViewMusik()
        {
            InitializeComponent();
            soundplayer = new SoundPlayer("SpielMusik.wav");
        }

        private void cbMusikstummschalten_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMusikstummschalten.Checked)
            {
                soundplayer.Stop();
            }
            else
            {
                soundplayer.Play();
            }
            
        }
    }
}
