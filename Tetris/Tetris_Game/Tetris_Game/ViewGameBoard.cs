using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Media;

namespace Tetris_Game
{
    public partial class ViewGameBoard : Form
    {
        private ControlerGameBoard controler;
        private MediaPlayer player;
        private int volume;
        private int difficulty;
        private string exeFolder;
        public ViewGameBoard()
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
            controler = new ControlerGameBoard(difficulty);
            controler.GameBoardChanged += onGameBoardChanged;
            controler.GameOver += onGameOver;
            controler.callRender();
            player = new MediaPlayer();
            player.Open(new Uri(exeFolder + @".\TetrisMusic.wav"));
            System.Diagnostics.Debug.WriteLine(volume);
            player.Volume = volume / 100.0f;
            player.Play();
            player.MediaEnded += new EventHandler(Media_Ended);
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
        }
        private void onGameOver(Object sender, EventArgs e)
        {
            int score = controler.GetScore();
            string input = Interaction.InputBox("Gib deinen Namen ein um deinen Score hochzuladen.", "", "");
            if (input != "")
            {
                Highscore highscore = new Highscore(input, score);
                if (highscore.highscoreHochladen())
                {
                    MessageBox.Show("Hochgeladen");
                }
                else
                {
                    MessageBox.Show("Etwas ist schiefgelaufen");

                }
            }
            player.Stop();
            this.Close();
        }

        private void ViewGameBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                controler.nachLinks();
            }
            else if (e.KeyCode == Keys.D)
            {
                controler.nachRechts();
            }
            else if (e.KeyCode == Keys.E)
            {
                controler.nachRechtsDrehen();
            }
            else if (e.KeyCode == Keys.Q)
            { 
                controler.nachLinksDrehen();
            }
            else if (e.KeyCode== Keys.S)
            {
                controler.nachUnten();
            }
        }

        private void onGameBoardChanged(object sender, EventArgs args)
        {
            GameBoard gameBoard = controler.GetGameBoardWithActiveBlock();

            this.lblScore.Text = gameBoard.Score.ToString();

            for (int i = 0; i < gameBoard.GameTileFarbe.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GameTileFarbe.GetLength(1); j++)
                {
                    this.Controls.Find("pictureBoxGameTile" + j + "_" + i, true)[0].BackColor = gameBoard.GameTileFarbe[i, j];
                }
            }
        }

        private void ViewGameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            controler.StopTimer();
            player.Stop();
            System.Threading.Thread.Sleep(100);
        }
    }
}
