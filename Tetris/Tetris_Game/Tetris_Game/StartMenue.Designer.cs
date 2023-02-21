namespace Tetris_Game
{
    partial class StartMenue
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
            this.lblTetris = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Einstellungenbtn = new System.Windows.Forms.Button();
            this.Steuerungbtn = new System.Windows.Forms.Button();
            this.btnViewHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTetris
            // 
            this.lblTetris.AutoSize = true;
            this.lblTetris.BackColor = System.Drawing.Color.Transparent;
            this.lblTetris.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTetris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTetris.Location = new System.Drawing.Point(87, 41);
            this.lblTetris.Name = "lblTetris";
            this.lblTetris.Size = new System.Drawing.Size(104, 38);
            this.lblTetris.TabIndex = 0;
            this.lblTetris.Text = "Tetris";
            // 
            // Startbtn
            // 
            this.Startbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Startbtn.Font = new System.Drawing.Font("Miriam Libre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Startbtn.Location = new System.Drawing.Point(37, 82);
            this.Startbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(208, 54);
            this.Startbtn.TabIndex = 1;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.SpielLaden);
            // 
            // Einstellungenbtn
            // 
            this.Einstellungenbtn.Font = new System.Drawing.Font("Miriam Libre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Einstellungenbtn.Location = new System.Drawing.Point(37, 284);
            this.Einstellungenbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Einstellungenbtn.Name = "Einstellungenbtn";
            this.Einstellungenbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Einstellungenbtn.Size = new System.Drawing.Size(208, 54);
            this.Einstellungenbtn.TabIndex = 2;
            this.Einstellungenbtn.Text = "Einstellungen";
            this.Einstellungenbtn.UseVisualStyleBackColor = true;
            this.Einstellungenbtn.Click += new System.EventHandler(this.EinstelungenAufrufen);
            // 
            // Steuerungbtn
            // 
            this.Steuerungbtn.Font = new System.Drawing.Font("Miriam Libre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steuerungbtn.Location = new System.Drawing.Point(37, 216);
            this.Steuerungbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Steuerungbtn.Name = "Steuerungbtn";
            this.Steuerungbtn.Size = new System.Drawing.Size(208, 56);
            this.Steuerungbtn.TabIndex = 3;
            this.Steuerungbtn.Text = "Steuerung";
            this.Steuerungbtn.UseVisualStyleBackColor = true;
            this.Steuerungbtn.Click += new System.EventHandler(this.Steuerungbtn_Click);
            // 
            // btnViewHighscore
            // 
            this.btnViewHighscore.Font = new System.Drawing.Font("Miriam Libre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHighscore.Location = new System.Drawing.Point(37, 148);
            this.btnViewHighscore.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewHighscore.Name = "btnViewHighscore";
            this.btnViewHighscore.Size = new System.Drawing.Size(208, 56);
            this.btnViewHighscore.TabIndex = 4;
            this.btnViewHighscore.Text = "Highscores";
            this.btnViewHighscore.UseVisualStyleBackColor = true;
            this.btnViewHighscore.Click += new System.EventHandler(this.btnViewHighscore_Click);
            // 
            // StartMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris_Game.Properties.Resources.TetrisHintergrund;
            this.ClientSize = new System.Drawing.Size(284, 597);
            this.Controls.Add(this.btnViewHighscore);
            this.Controls.Add(this.Steuerungbtn);
            this.Controls.Add(this.Einstellungenbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.lblTetris);
            this.Name = "StartMenue";
            this.Text = "StartMenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTetris;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Einstellungenbtn;
        private System.Windows.Forms.Button Steuerungbtn;
        private System.Windows.Forms.Button btnViewHighscore;
    }
}