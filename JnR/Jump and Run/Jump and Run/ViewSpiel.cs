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

namespace Jump_and_Run
{
    public partial class ViewSpiel : Form
    {
        bool sprung = false;
        int sprungGeschwindigkeit;
        int gravitation;
        int score = 0;
        int hindernisGeschwindigkeit = 10;
        Random rand = new Random();
        int position;
        bool schuss = false;
        bool isGameOver = false;
        private SoundPlayer soundplayer;


        public ViewSpiel()
        {
            InitializeComponent();

            spielStart();

            soundplayer = new SoundPlayer("SpielMusik.wav");
            soundplayer.Play();

        }


        private void mainSpielTimer(object sender, EventArgs e)
        {
            //Sprung
            pbxSpieler.Top += sprungGeschwindigkeit;
            txtScore.Text = "Score: " + score;

            if (sprung == true && gravitation < 0)
            {
                sprung = false;
            }

            if (sprung == true)
            {
                sprungGeschwindigkeit = -12;
                gravitation -= 1;
            }
            else
            {
                sprungGeschwindigkeit = 12;
            }

            if (pbxSpieler.Top > 277 && sprung == false)
            {
                gravitation = 16;
                pbxSpieler.Top = 278;
                sprungGeschwindigkeit = 0;
            }
            //Sprung Ende


            //Sterben und hindernisse/gegner zurücksetzen und schuss interaktion

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "hindernis" || x is PictureBox && (string)x.Tag == "gegner")
                {
                    x.Left -= hindernisGeschwindigkeit;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (pbxSpieler.Bounds.IntersectsWith(x.Bounds))
                    {
                        spielTimer.Stop();
                        txtScore.Text += " drück R zum neustarten ";
                        isGameOver = true;
                    }
                }


                if (x is PictureBox && (string)x.Tag == "schuss")
                {
                    x.Left += 25;

                    if (x.Left > 500)
                    {
                        schussEntfernen(((PictureBox)x));
                    }

                    if (pbxGegnerVogel1.Bounds.IntersectsWith(x.Bounds))
                    {
                        schussEntfernen(((PictureBox)x));
                        pbxGegnerVogel1.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score += 1;
                    }

                }

            }
        }


        //Taste wird gedrückt
        private void tasteUnten(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && sprung == false)
            {
                sprung = true;
            }

            if (e.KeyCode == Keys.Space && schuss == false)
            {
                schussErstellen();
                schuss = true;
            }

        }

        //Taste wird nicht gedrückt
        private void tasteOben(object sender, KeyEventArgs e)
        {
            if (sprung == true)
            {
                sprung = false;
            }

            if (schuss == true)
            {
                schuss = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                spielStart();
            }

            if (e.KeyCode == Keys.S && isGameOver == true)
            {
                ViewHighscore ViewHighscore = new ViewHighscore(score);
                ViewHighscore.Show();
            }
        }

        //schuss Erstellen
        private void schussErstellen()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Maroon;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = pbxSpieler.Left + pbxSpieler.Width;
            bullet.Top = pbxSpieler.Top + pbxSpieler.Height / 2 - 30;

            bullet.Tag = "schuss";

            this.Controls.Add(bullet);

        }


        //schuss Entfernen
        private void schussEntfernen(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }




        private void spielStart()
        {
            sprungGeschwindigkeit = 0;
            sprung = false;
            schuss = false;
            score = 0;
            hindernisGeschwindigkeit = 10;
            txtScore.Text = "Score: " + score;
            pbxSpieler.Top = 278;
            isGameOver = false;

            //Hindernisse zum ersten mal zurücksetzen
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "hindernis" || x is PictureBox && (string)x.Tag == "gegner")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }

            //spielTimer start
            spielTimer.Start();

        }
    }
}
