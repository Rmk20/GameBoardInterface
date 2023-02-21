namespace Jump_and_Run
{
    partial class ViewSpiel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSpiel));
            this.txtScore = new System.Windows.Forms.Label();
            this.spielTimer = new System.Windows.Forms.Timer(this.components);
            this.pbxHindernisStein1 = new System.Windows.Forms.PictureBox();
            this.pbxSpieler = new System.Windows.Forms.PictureBox();
            this.pbxGegnerVogel1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHindernisStein1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpieler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGegnerVogel1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(13, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(131, 31);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score:  0";
            // 
            // spielTimer
            // 
            this.spielTimer.Interval = 20;
            this.spielTimer.Tick += new System.EventHandler(this.mainSpielTimer);
            // 
            // pbxHindernisStein1
            // 
            this.pbxHindernisStein1.BackColor = System.Drawing.Color.Transparent;
            this.pbxHindernisStein1.Image = global::Jump_and_Run.Properties.Resources.pngegg;
            this.pbxHindernisStein1.Location = new System.Drawing.Point(367, 354);
            this.pbxHindernisStein1.Name = "pbxHindernisStein1";
            this.pbxHindernisStein1.Size = new System.Drawing.Size(84, 133);
            this.pbxHindernisStein1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHindernisStein1.TabIndex = 5;
            this.pbxHindernisStein1.TabStop = false;
            this.pbxHindernisStein1.Tag = "hindernis";
            // 
            // pbxSpieler
            // 
            this.pbxSpieler.BackColor = System.Drawing.Color.Transparent;
            this.pbxSpieler.Image = ((System.Drawing.Image)(resources.GetObject("pbxSpieler.Image")));
            this.pbxSpieler.Location = new System.Drawing.Point(44, 278);
            this.pbxSpieler.Name = "pbxSpieler";
            this.pbxSpieler.Size = new System.Drawing.Size(100, 143);
            this.pbxSpieler.TabIndex = 2;
            this.pbxSpieler.TabStop = false;
            // 
            // pbxGegnerVogel1
            // 
            this.pbxGegnerVogel1.BackColor = System.Drawing.Color.Transparent;
            this.pbxGegnerVogel1.Image = global::Jump_and_Run.Properties.Resources.GegnerModell_Fledermaus;
            this.pbxGegnerVogel1.Location = new System.Drawing.Point(607, 266);
            this.pbxGegnerVogel1.Name = "pbxGegnerVogel1";
            this.pbxGegnerVogel1.Size = new System.Drawing.Size(116, 97);
            this.pbxGegnerVogel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGegnerVogel1.TabIndex = 7;
            this.pbxGegnerVogel1.TabStop = false;
            this.pbxGegnerVogel1.Tag = "gegner";
            // 
            // ViewSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jump_and_Run.Properties.Resources.Cave_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxGegnerVogel1);
            this.Controls.Add(this.pbxHindernisStein1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pbxSpieler);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewSpiel";
            this.Text = "Jump and Run spielen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tasteUnten);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tasteOben);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHindernisStein1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpieler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGegnerVogel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxSpieler;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer spielTimer;
        private System.Windows.Forms.PictureBox pbxHindernisStein1;
        private System.Windows.Forms.PictureBox pbxGegnerVogel1;
    }
}