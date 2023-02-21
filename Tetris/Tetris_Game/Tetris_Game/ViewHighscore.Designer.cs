namespace Tetris_Game
{
    partial class ViewHighscore
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
            this.dgvHighscores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighscores
            // 
            this.dgvHighscores.AllowUserToAddRows = false;
            this.dgvHighscores.AllowUserToDeleteRows = false;
            this.dgvHighscores.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvHighscores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighscores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHighscores.Location = new System.Drawing.Point(0, 0);
            this.dgvHighscores.Margin = new System.Windows.Forms.Padding(0);
            this.dgvHighscores.Name = "dgvHighscores";
            this.dgvHighscores.ReadOnly = true;
            this.dgvHighscores.RowHeadersVisible = false;
            this.dgvHighscores.RowHeadersWidth = 66;
            this.dgvHighscores.Size = new System.Drawing.Size(287, 570);
            this.dgvHighscores.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Score";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 130;
            // 
            // ViewHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris_Game.Properties.Resources.TetrisHintergrund;
            this.ClientSize = new System.Drawing.Size(286, 568);
            this.Controls.Add(this.dgvHighscores);
            this.Name = "ViewHighscore";
            this.Text = "ViewHighscore";
            this.Load += new System.EventHandler(this.ViewHighscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighscores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}