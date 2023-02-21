using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace Tetris_Game
{
    public partial class Einstelungen : Form 
    {
        private int volume;
        private int difficulty;
        private string exeFolder;
        public Einstelungen()
        {
            InitializeComponent();
            try
            {
                exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                using (StreamReader sr = new StreamReader(exeFolder + @"\settings.txt"))
                {
                    string line1 = sr.ReadLine();
                    if (line1 == null)
                    {
                        throw new Exception();
                    }
                    volume = Convert.ToInt32(line1);
                    string line2 = sr.ReadLine();
                    if (line2 == null)
                    {
                        throw new Exception();
                    }
                    difficulty = Convert.ToInt32(line2);
                }
            }
            catch
            {
                volume = 100;
                difficulty = 1;
            }
            trackBar1.Value= volume;
            cbxSchwierigkeit.Text = difficulty.ToString();
            lblLautstaerkeProzent.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {            
            lblLautstaerkeProzent.Text = trackBar1.Value.ToString();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string dificulty = "1";
            if(cbxSchwierigkeit.Text == "2" || cbxSchwierigkeit.Text == "3")
            {
                dificulty = cbxSchwierigkeit.Text;
            }
            using (StreamWriter sw = File.CreateText(exeFolder + @"\settings.txt"))
            {
                sw.WriteLine(trackBar1.Value.ToString());
                sw.WriteLine(dificulty);
            }


        }
    }
}
