namespace back_office
{
    partial class connexion
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
            this.idConnexion = new System.Windows.Forms.TextBox();
            this.mdpConnexion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.titre_Connexion = new System.Windows.Forms.Label();
            this.label_mdpConnexion = new System.Windows.Forms.Label();
            this.label_idConnexion = new System.Windows.Forms.Label();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // idConnexion
            // 
            this.idConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConnexion.Location = new System.Drawing.Point(325, 122);
            this.idConnexion.Name = "idConnexion";
            this.idConnexion.Size = new System.Drawing.Size(176, 31);
            this.idConnexion.TabIndex = 1;
            // 
            // mdpConnexion
            // 
            this.mdpConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mdpConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpConnexion.Location = new System.Drawing.Point(325, 181);
            this.mdpConnexion.Name = "mdpConnexion";
            this.mdpConnexion.Size = new System.Drawing.Size(176, 31);
            this.mdpConnexion.TabIndex = 2;
            this.mdpConnexion.Enter += new System.EventHandler(this.MdpConnexion_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(39)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.dgv_users);
            this.panel1.Controls.Add(this.btn_connexion);
            this.panel1.Controls.Add(this.titre_Connexion);
            this.panel1.Controls.Add(this.label_mdpConnexion);
            this.panel1.Controls.Add(this.label_idConnexion);
            this.panel1.Controls.Add(this.mdpConnexion);
            this.panel1.Controls.Add(this.idConnexion);
            this.panel1.Location = new System.Drawing.Point(70, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 349);
            this.panel1.TabIndex = 3;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connexion.BackColor = System.Drawing.Color.White;
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.Location = new System.Drawing.Point(325, 249);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(176, 42);
            this.btn_connexion.TabIndex = 6;
            this.btn_connexion.Text = "se connecter";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.Btn_connexion_Click);
            // 
            // titre_Connexion
            // 
            this.titre_Connexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titre_Connexion.AutoSize = true;
            this.titre_Connexion.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_Connexion.ForeColor = System.Drawing.Color.White;
            this.titre_Connexion.Location = new System.Drawing.Point(212, 11);
            this.titre_Connexion.Name = "titre_Connexion";
            this.titre_Connexion.Size = new System.Drawing.Size(270, 65);
            this.titre_Connexion.TabIndex = 5;
            this.titre_Connexion.Text = "Connexion";
            // 
            // label_mdpConnexion
            // 
            this.label_mdpConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mdpConnexion.AutoSize = true;
            this.label_mdpConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdpConnexion.ForeColor = System.Drawing.Color.White;
            this.label_mdpConnexion.Location = new System.Drawing.Point(204, 188);
            this.label_mdpConnexion.Name = "label_mdpConnexion";
            this.label_mdpConnexion.Size = new System.Drawing.Size(105, 20);
            this.label_mdpConnexion.TabIndex = 4;
            this.label_mdpConnexion.Text = "Mot de passe";
            // 
            // label_idConnexion
            // 
            this.label_idConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_idConnexion.AutoSize = true;
            this.label_idConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idConnexion.ForeColor = System.Drawing.Color.White;
            this.label_idConnexion.Location = new System.Drawing.Point(204, 122);
            this.label_idConnexion.Name = "label_idConnexion";
            this.label_idConnexion.Size = new System.Drawing.Size(80, 20);
            this.label_idConnexion.TabIndex = 3;
            this.label_idConnexion.Text = "Identifiant";
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(44, 79);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(240, 150);
            this.dgv_users.TabIndex = 7;
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(163)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox idConnexion;
        private System.Windows.Forms.TextBox mdpConnexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Label titre_Connexion;
        private System.Windows.Forms.Label label_mdpConnexion;
        private System.Windows.Forms.Label label_idConnexion;
        private System.Windows.Forms.DataGridView dgv_users;
    }
}