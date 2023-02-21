namespace Jump_and_Run
{
    partial class ViewMusik
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
            this.cbMusikstummschalten = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbMusikstummschalten
            // 
            this.cbMusikstummschalten.AutoSize = true;
            this.cbMusikstummschalten.Location = new System.Drawing.Point(23, 28);
            this.cbMusikstummschalten.Name = "cbMusikstummschalten";
            this.cbMusikstummschalten.Size = new System.Drawing.Size(127, 17);
            this.cbMusikstummschalten.TabIndex = 0;
            this.cbMusikstummschalten.Text = "Musik stummschalten";
            this.cbMusikstummschalten.UseVisualStyleBackColor = true;
            this.cbMusikstummschalten.CheckedChanged += new System.EventHandler(this.cbMusikstummschalten_CheckedChanged);
            // 
            // ViewMusik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 61);
            this.Controls.Add(this.cbMusikstummschalten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewMusik";
            this.Text = "Musikeinstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMusikstummschalten;
    }
}