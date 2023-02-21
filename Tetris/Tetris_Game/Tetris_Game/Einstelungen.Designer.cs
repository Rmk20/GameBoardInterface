namespace Tetris_Game
{
    partial class Einstelungen
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.cbxSchwierigkeit = new System.Windows.Forms.ComboBox();
            this.lblLautstaerke = new System.Windows.Forms.Label();
            this.lblLautstaerkeProzent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShwierigkeit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(43, 135);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(185, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpeichern.Location = new System.Drawing.Point(56, 367);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(156, 34);
            this.btnSpeichern.TabIndex = 2;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // cbxSchwierigkeit
            // 
            this.cbxSchwierigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSchwierigkeit.FormattingEnabled = true;
            this.cbxSchwierigkeit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxSchwierigkeit.Location = new System.Drawing.Point(56, 271);
            this.cbxSchwierigkeit.Name = "cbxSchwierigkeit";
            this.cbxSchwierigkeit.Size = new System.Drawing.Size(156, 28);
            this.cbxSchwierigkeit.TabIndex = 3;
            this.cbxSchwierigkeit.Text = "Auswählen";
            // 
            // lblLautstaerke
            // 
            this.lblLautstaerke.AutoSize = true;
            this.lblLautstaerke.BackColor = System.Drawing.Color.Black;
            this.lblLautstaerke.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLautstaerke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLautstaerke.Location = new System.Drawing.Point(43, 75);
            this.lblLautstaerke.Name = "lblLautstaerke";
            this.lblLautstaerke.Size = new System.Drawing.Size(113, 30);
            this.lblLautstaerke.TabIndex = 4;
            this.lblLautstaerke.Text = "Lautstärke";
            this.lblLautstaerke.UseCompatibleTextRendering = true;
            // 
            // lblLautstaerkeProzent
            // 
            this.lblLautstaerkeProzent.AutoSize = true;
            this.lblLautstaerkeProzent.BackColor = System.Drawing.Color.Black;
            this.lblLautstaerkeProzent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLautstaerkeProzent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLautstaerkeProzent.Location = new System.Drawing.Point(162, 75);
            this.lblLautstaerkeProzent.Name = "lblLautstaerkeProzent";
            this.lblLautstaerkeProzent.Size = new System.Drawing.Size(51, 25);
            this.lblLautstaerkeProzent.TabIndex = 5;
            this.lblLautstaerkeProzent.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(219, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // lblShwierigkeit
            // 
            this.lblShwierigkeit.AutoSize = true;
            this.lblShwierigkeit.BackColor = System.Drawing.Color.Black;
            this.lblShwierigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShwierigkeit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShwierigkeit.Location = new System.Drawing.Point(64, 208);
            this.lblShwierigkeit.Name = "lblShwierigkeit";
            this.lblShwierigkeit.Size = new System.Drawing.Size(141, 30);
            this.lblShwierigkeit.TabIndex = 7;
            this.lblShwierigkeit.Text = "Schwierigkeit";
            this.lblShwierigkeit.UseCompatibleTextRendering = true;
            // 
            // Einstelungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris_Game.Properties.Resources.TetrisHintergrund;
            this.ClientSize = new System.Drawing.Size(269, 564);
            this.Controls.Add(this.lblShwierigkeit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLautstaerkeProzent);
            this.Controls.Add(this.lblLautstaerke);
            this.Controls.Add(this.cbxSchwierigkeit);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.trackBar1);
            this.Name = "Einstelungen";
            this.Text = "Einstelungen";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.ComboBox cbxSchwierigkeit;
        private System.Windows.Forms.Label lblLautstaerke;
        private System.Windows.Forms.Label lblLautstaerkeProzent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShwierigkeit;
    }
}