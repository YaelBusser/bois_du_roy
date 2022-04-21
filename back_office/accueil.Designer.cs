namespace back_office
{
    partial class accueil
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
            this.blockAccueil = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.Label();
            this.imgStats = new System.Windows.Forms.PictureBox();
            this.filtresAccueil = new System.Windows.Forms.ComboBox();
            this.blockAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStats)).BeginInit();
            this.SuspendLayout();
            // 
            // blockAccueil
            // 
            this.blockAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(39)))), ((int)(((byte)(23)))));
            this.blockAccueil.Controls.Add(this.filtresAccueil);
            this.blockAccueil.Controls.Add(this.txtNotes);
            this.blockAccueil.Controls.Add(this.imgStats);
            this.blockAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockAccueil.Location = new System.Drawing.Point(0, 0);
            this.blockAccueil.Name = "blockAccueil";
            this.blockAccueil.Size = new System.Drawing.Size(787, 502);
            this.blockAccueil.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.AutoSize = true;
            this.txtNotes.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(264, 60);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(228, 45);
            this.txtNotes.TabIndex = 2;
            this.txtNotes.Text = "Notes de frais";
            // 
            // imgStats
            // 
            this.imgStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStats.Image = global::back_office.Properties.Resources.bar_chart_2_256;
            this.imgStats.Location = new System.Drawing.Point(14, 12);
            this.imgStats.Name = "imgStats";
            this.imgStats.Size = new System.Drawing.Size(25, 25);
            this.imgStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStats.TabIndex = 0;
            this.imgStats.TabStop = false;
            this.imgStats.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // filtresAccueil
            // 
            this.filtresAccueil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtresAccueil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filtresAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.filtresAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtresAccueil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtresAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtresAccueil.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtresAccueil.FormattingEnabled = true;
            this.filtresAccueil.IntegralHeight = false;
            this.filtresAccueil.Items.AddRange(new object[] {
            "Tous",
            "En attente"});
            this.filtresAccueil.Location = new System.Drawing.Point(625, 12);
            this.filtresAccueil.Name = "filtresAccueil";
            this.filtresAccueil.Size = new System.Drawing.Size(150, 25);
            this.filtresAccueil.TabIndex = 3;
            this.filtresAccueil.Tag = "";
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(163)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(787, 502);
            this.Controls.Add(this.blockAccueil);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accueil";
            this.Text = "accueil";
            this.blockAccueil.ResumeLayout(false);
            this.blockAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel blockAccueil;
        private System.Windows.Forms.PictureBox imgStats;
        private System.Windows.Forms.Label txtNotes;
        private System.Windows.Forms.ComboBox filtresAccueil;
    }
}