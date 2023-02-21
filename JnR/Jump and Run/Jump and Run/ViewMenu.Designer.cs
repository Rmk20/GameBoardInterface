namespace Jump_and_Run
{
    partial class ViewMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpielStarten = new System.Windows.Forms.Button();
            this.btnMusikEinstellen = new System.Windows.Forms.Button();
            this.lblHighscoreliste = new System.Windows.Forms.Label();
            this.lblbester = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbJnRShooter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbJnRShooter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpielStarten
            // 
            this.btnSpielStarten.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpielStarten.Location = new System.Drawing.Point(154, 188);
            this.btnSpielStarten.Name = "btnSpielStarten";
            this.btnSpielStarten.Size = new System.Drawing.Size(135, 56);
            this.btnSpielStarten.TabIndex = 0;
            this.btnSpielStarten.Text = "Spielen";
            this.btnSpielStarten.UseVisualStyleBackColor = true;
            this.btnSpielStarten.Click += new System.EventHandler(this.btnSpielStarten_Click);
            // 
            // btnMusikEinstellen
            // 
            this.btnMusikEinstellen.BackColor = System.Drawing.Color.Transparent;
            this.btnMusikEinstellen.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusikEinstellen.ForeColor = System.Drawing.Color.Black;
            this.btnMusikEinstellen.Location = new System.Drawing.Point(154, 261);
            this.btnMusikEinstellen.Name = "btnMusikEinstellen";
            this.btnMusikEinstellen.Size = new System.Drawing.Size(135, 58);
            this.btnMusikEinstellen.TabIndex = 1;
            this.btnMusikEinstellen.Text = "Musik einstellen";
            this.btnMusikEinstellen.UseVisualStyleBackColor = false;
            this.btnMusikEinstellen.Click += new System.EventHandler(this.btnMusikEinstellen_Click);
            // 
            // lblHighscoreliste
            // 
            this.lblHighscoreliste.AutoSize = true;
            this.lblHighscoreliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscoreliste.Location = new System.Drawing.Point(586, 111);
            this.lblHighscoreliste.Name = "lblHighscoreliste";
            this.lblHighscoreliste.Size = new System.Drawing.Size(118, 25);
            this.lblHighscoreliste.TabIndex = 2;
            this.lblHighscoreliste.Text = "Highscore";
            // 
            // lblbester
            // 
            this.lblbester.AutoSize = true;
            this.lblbester.Location = new System.Drawing.Point(588, 153);
            this.lblbester.Name = "lblbester";
            this.lblbester.Size = new System.Drawing.Size(35, 13);
            this.lblbester.TabIndex = 3;
            this.lblbester.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(691, 153);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // pbJnRShooter
            // 
            this.pbJnRShooter.BackColor = System.Drawing.Color.Transparent;
            this.pbJnRShooter.Image = global::Jump_and_Run.Properties.Resources.output_onlinepngtools;
            this.pbJnRShooter.Location = new System.Drawing.Point(51, 38);
            this.pbJnRShooter.Margin = new System.Windows.Forms.Padding(2);
            this.pbJnRShooter.Name = "pbJnRShooter";
            this.pbJnRShooter.Size = new System.Drawing.Size(343, 145);
            this.pbJnRShooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJnRShooter.TabIndex = 5;
            this.pbJnRShooter.TabStop = false;
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jump_and_Run.Properties.Resources._360_F_232444335_HCNY6biiF3TVrCqoMepz3Jjem8DchGYo;
            this.ClientSize = new System.Drawing.Size(421, 355);
            this.Controls.Add(this.pbJnRShooter);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblbester);
            this.Controls.Add(this.lblHighscoreliste);
            this.Controls.Add(this.btnMusikEinstellen);
            this.Controls.Add(this.btnSpielStarten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewMenu";
            this.Text = "Jump and Run";
            ((System.ComponentModel.ISupportInitialize)(this.pbJnRShooter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpielStarten;
        private System.Windows.Forms.Button btnMusikEinstellen;
        private System.Windows.Forms.Label lblHighscoreliste;
        private System.Windows.Forms.Label lblbester;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbJnRShooter;
    }
}

